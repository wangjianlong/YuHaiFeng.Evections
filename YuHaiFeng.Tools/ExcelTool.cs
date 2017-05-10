using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using YuHaiFeng.Commons;

namespace YuHaiFeng.Tools
{
    public static class ExcelTool
    {
        public static void SaveFiles(this string filePath,List<string> files)
        {
            HSSFWorkbook wk = new HSSFWorkbook();
            ISheet sheet = wk.CreateSheet("目录文件列表");
            IRow row = sheet.CreateRow(1);
            var line = 1;
            foreach(var item in files)
            {
                row = sheet.CreateRow(line++);
                var cell = ExcelHelper.GetCell(row, 0);
                cell.SetCellValue(item);
            }

            using (var fs=new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                wk.Write(fs);
            }
        }
        public static List<string> ReadFile(this string filePath)
        {
            var list = new List<string>();
            IWorkbook workbook = filePath.OpenExcel();
            var sheet = workbook.GetSheetAt(0);
            for(var i = 1; i <= sheet.LastRowNum; i++)
            {
                var row = sheet.GetRow(i);
                var cell = ExcelHelper.GetCell(row, 0);
                list.Add(cell.ToString());
            }
            return list;
        }
    }
}
