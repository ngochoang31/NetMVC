using System;
using System.Data;
using System.IO;
using OfficeOpenXml;

namespace DemoMVC.Models.Process
{
    public class ExcelProcess
    {
        public DataTable ExcelToDataTable(string filePath)
        {
            // ✅ Cấp phép EPPlus (chuẩn 5+ / 6+ / 7+ / 8+)
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            DataTable dt = new DataTable();
            FileInfo existingFile = new FileInfo(filePath);

            using (var package = new ExcelPackage(existingFile))
            {
                var worksheet = package.Workbook.Worksheets[0]; // lấy sheet đầu tiên
                int colCount = worksheet.Dimension.End.Column;
                int rowCount = worksheet.Dimension.End.Row;

                // Tạo cột theo dòng đầu tiên
                for (int col = 1; col <= colCount; col++)
                {
                    dt.Columns.Add(worksheet.Cells[1, col].Text);
                }

                // Đọc dữ liệu từ dòng 2
                for (int row = 2; row <= rowCount; row++)
                {
                    DataRow newRow = dt.NewRow();
                    for (int col = 1; col <= colCount; col++)
                    {
                        newRow[col - 1] = worksheet.Cells[row, col].Text;
                    }
                    dt.Rows.Add(newRow);
                }
            }

            return dt;
        }
    }
}