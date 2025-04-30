using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace kitapIslemleriForm
{
    //internal class ExcelHelper
    //{
    //    public static void ExportToExcel(DataGridView dataGridView, string filePath)
    //    {
    //        try
    //        {
    //            using (var workbook = new XLWorkbook())
    //            {
    //                var worksheet = workbook.AddWorksheet("Kitaplar");

    //                // DataGridView'deki sütun başlıklarını Excel'e ekliyoruz
    //                for (int i = 0; i < dataGridView.Columns.Count; i++)
    //                {
    //                    worksheet.Row(1).Cell(i + 1).Value = dataGridView.Columns[i].HeaderText;
    //                }

    //                // DataGridView'deki verileri Excel'e aktarıyoruz
    //                for (int i = 0; i < dataGridView.Rows.Count; i++)
    //                {
    //                    for (int j = 0; j < dataGridView.Columns.Count; j++)
    //                    {
    //                        var cellValue = dataGridView.Rows[i].Cells[j].Value;
    //                        if (cellValue != null)
    //                        {
    //                            // Verinin türüne göre uygun şekilde aktarım yapıyoruz
    //                            if (cellValue is DateTime)
    //                                worksheet.Row(i + 2).Cell(j + 1).Value = (DateTime)cellValue;
    //                            else if (cellValue is decimal)
    //                                worksheet.Row(i + 2).Cell(j + 1).Value = (decimal)cellValue;
    //                            else if (cellValue is int)
    //                                worksheet.Row(i + 2).Cell(j + 1).Value = (int)cellValue;
    //                            else if (cellValue is bool)
    //                                worksheet.Row(i + 2).Cell(j + 1).Value = (bool)cellValue;
    //                            else
    //                                worksheet.Row(i + 2).Cell(j + 1).Value = cellValue.ToString(); // Diğer türler için string'e dönüştürme
    //                        }
    //                        else
    //                        {
    //                            worksheet.Row(i + 2).Cell(j + 1).Value = ""; // Null ise boş hücre
    //                        }
    //                    }
    //                }

    //                // Excel dosyasını kaydediyoruz
    //                workbook.SaveAs(filePath);
    //                MessageBox.Show("Veriler başarıyla Excel'e aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        }
    //    }
    //}
}
