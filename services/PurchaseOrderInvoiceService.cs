using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Management_System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Inventory_Management_System.Services
{
    public class PurchaseOrderInvoiceService
    {
        public DataSet GetPoInvoice(int poID)
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();
                    string sql = @"SELECT 
                            po.`POID`, 
                            po.`PONumber`, 
                            po.`SupplierID`,
                            s.`Name` AS SupplierName,
                            s.`Address` AS SupplierAddress,
                            po.`ItemName`,
                            po.`UnitPrice`,
                            po.`NumberOfUnits` AS Quantity,
                            (po.`UnitPrice` * po.`NumberOfUnits`) AS TotalCost,
                            po.`OrderDate`, 
                            po.`ExpectedDeliveryDate`, 
                            po.`CreatedBy`, 
                            po.`ApprovedBy`, 
                            po.`Notes`, 
                            po.`CreatedAt`, 
                            po.`Status`
                        FROM `purchaseorders` po
                        JOIN `suppliers` s ON po.`SupplierID` = s.`SupplierID`
                        WHERE po.`POID` = @poID";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@poID", poID);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
        public void ExportPoInvoiceToPdf(int poID, string filePath)
        {
            // Get the data from database
            DataSet ds = GetPoInvoice(poID);

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No purchase order data found for the given ID.");
                return;
            }

            DataRow poData = ds.Tables[0].Rows[0];

            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Add Title
            Paragraph title = new Paragraph("PURCHASE ORDER INVOICE",
                FontFactory.GetFont("Arial", 16, Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
            doc.Add(new Paragraph(" ")); // Empty line

            // Add Issued To section (Supplier in this case)
            Paragraph issuedTo = new Paragraph("SUPPLIER:",
                FontFactory.GetFont("Arial", 12, Font.BOLD));
            doc.Add(issuedTo);

            Paragraph supplierInfo = new Paragraph(
                $"{poData["SupplierName"]}\n{poData["SupplierAddress"]}",
                FontFactory.GetFont("Arial", 10, Font.NORMAL));
            doc.Add(supplierInfo);
            doc.Add(new Paragraph(" "));

            // Add PO Information
            Paragraph poInfo = new Paragraph();
            poInfo.Add(new Chunk("PO NUMBER: ",
                FontFactory.GetFont("Arial", 12, Font.BOLD)));
            poInfo.Add(new Chunk($"{poData["PONumber"]}\n",
                FontFactory.GetFont("Arial", 10, Font.NORMAL)));
            poInfo.Add(new Chunk("ORDER DATE: ",
                FontFactory.GetFont("Arial", 12, Font.BOLD)));
            poInfo.Add(new Chunk($"{Convert.ToDateTime(poData["OrderDate"]).ToString("dd.MM.yyyy")}\n",
                FontFactory.GetFont("Arial", 10, Font.NORMAL)));
            poInfo.Add(new Chunk("EXPECTED DELIVERY: ",
                FontFactory.GetFont("Arial", 12, Font.BOLD)));
            poInfo.Add(new Chunk($"{Convert.ToDateTime(poData["ExpectedDeliveryDate"]).ToString("dd.MM.yyyy")}",
                FontFactory.GetFont("Arial", 10, Font.NORMAL)));
            doc.Add(poInfo);

            // Add line separator
            doc.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0f, 100f, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            doc.Add(new Paragraph(" "));

            // Add Description title
            Paragraph descriptionTitle = new Paragraph("ITEMS ORDERED",
                FontFactory.GetFont("Arial", 12, Font.BOLD));
            doc.Add(descriptionTitle);
            doc.Add(new Paragraph(" "));

            // Create table for items
            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;

            // Add table headers
            AddHeaderCell(table, "ITEM DESCRIPTION");
            AddHeaderCell(table, "UNIT PRICE");
            AddHeaderCell(table, "QUANTITY");
            AddHeaderCell(table, "TOTAL");

            // Add items
            decimal subtotal = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string itemName = row["ItemName"].ToString();
                string unitPrice = Convert.ToDecimal(row["UnitPrice"]).ToString("C");
                string quantity = row["Quantity"].ToString();
                string total = Convert.ToDecimal(row["TotalCost"]).ToString("C");
                subtotal += Convert.ToDecimal(row["TotalCost"]);

                AddItemRow(table, itemName, unitPrice, quantity, total);
            }

            doc.Add(table);
            doc.Add(new Paragraph(" "));

            // Add subtotal section
            PdfPTable subtotalTable = new PdfPTable(3);
            subtotalTable.WidthPercentage = 100;

            AddSubtotalCell(subtotalTable, "SUBTOTAL", Element.ALIGN_LEFT, true);
            AddSubtotalCell(subtotalTable, "TOTAL", Element.ALIGN_LEFT, false);
            AddSubtotalCell(subtotalTable, subtotal.ToString("C"), Element.ALIGN_RIGHT, false);

            // Add notes if available
            if (!string.IsNullOrEmpty(poData["Notes"].ToString()))
            {
                doc.Add(new Paragraph(" "));
                Paragraph notesTitle = new Paragraph("NOTES:",
                    FontFactory.GetFont("Arial", 12, Font.BOLD));
                doc.Add(notesTitle);

                Paragraph notes = new Paragraph(poData["Notes"].ToString(),
                    FontFactory.GetFont("Arial", 10, Font.NORMAL));
                doc.Add(notes);
            }

            doc.Add(subtotalTable);
            doc.Close();
        }

        // Helper methods (same as previous example)
        private void AddHeaderCell(PdfPTable table, string text)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text,
                FontFactory.GetFont("Arial", 10, Font.BOLD)));
            cell.BackgroundColor = new BaseColor(240, 240, 240);
            cell.BorderWidth = 0.5f;
            cell.Padding = 5;
            table.AddCell(cell);
        }

        private void AddItemRow(PdfPTable table, string description, string unitPrice, string qty, string total)
        {
            table.AddCell(new PdfPCell(new Phrase(description,
                FontFactory.GetFont("Arial", 10, Font.NORMAL))));
            table.AddCell(new PdfPCell(new Phrase(unitPrice,
                FontFactory.GetFont("Arial", 10, Font.NORMAL))));
            table.AddCell(new PdfPCell(new Phrase(qty,
                FontFactory.GetFont("Arial", 10, Font.NORMAL))));
            table.AddCell(new PdfPCell(new Phrase(total,
                FontFactory.GetFont("Arial", 10, Font.NORMAL))));
        }

        private void AddSubtotalCell(PdfPTable table, string text, int alignment, bool isHeader)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text,
                FontFactory.GetFont("Arial", isHeader ? 12 : 10, isHeader ? Font.BOLD : Font.NORMAL)));
            cell.Border = PdfPCell.NO_BORDER;
            cell.HorizontalAlignment = alignment;
            cell.Padding = 5;
            table.AddCell(cell);
        }
    }
}
