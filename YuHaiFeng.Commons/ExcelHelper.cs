using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace YuHaiFeng.Commons
{
    public static class ExcelHelper
    {
        public static IWorkbook OpenExcel(this string filePath)
        {
            IWorkbook workbook = null;
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            {
                workbook = WorkbookFactory.Create(fs);
            }
            return workbook;
        }

        public static ICell GetCell(IRow row, int line, IRow modelRow = null)
        {
            ICell cell = row.GetCell(line);
            if (cell == null)
            {
                if (modelRow != null)
                {
                    cell = row.CreateCell(line, modelRow.GetCell(line).CellType);
                    cell.CellStyle = modelRow.GetCell(line).CellStyle;
                }
                else
                {
                    cell = row.CreateCell(line);
                }
            }
            return cell;
        }

    }
}
