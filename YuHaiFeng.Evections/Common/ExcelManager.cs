using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using YuHaiFeng.Evections.Models;

namespace YuHaiFeng.Evections.Common
{
    public static class ExcelManager
    {
        private static string _modelQQFilePath { get; set; }
        static ExcelManager()
        {
            _modelQQFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Excels", System.Configuration.ConfigurationManager.AppSettings["QQ"]);
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
        public static IWorkbook OpenExcel(this string filePath)
        {
            IWorkbook workbook = null;
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            {
                workbook = WorkbookFactory.Create(fs);
            }
            return workbook;
        }

        public static List<QQ> AnalyzeQQ(string filepath,string remark)
        {
            var list = new List<QQ>();
            IWorkbook workbook = filepath.OpenExcel();
            if (workbook != null)
            {
                ISheet sheet = workbook.GetSheetAt(0);
                if (sheet != null)
                {
                    for(var i = 1; i <= sheet.LastRowNum; i++)
                    {
                        var row = sheet.GetRow(i);
                        if (row != null)
                        {
                            var cell = row.GetCell(0);
                            if (cell != null)
                            {
                                if (!string.IsNullOrEmpty(cell.ToString()))
                                {
                                    list.Add(new QQ { Number = cell.ToString(), Remark = remark });
                                }
                               
                            }
                        }
                    }
                }
            }
            return list;
        }

        public static IWorkbook SaveQQ(List<QQ> list)
        {
            IWorkbook workbook = _modelQQFilePath.OpenExcel();
            if (workbook != null)
            {
                ISheet sheet = workbook.GetSheetAt(0);
                if (sheet != null)
                {
                    var modelrow = sheet.GetRow(0);
                    var startline = 1;
                    foreach(var qq in list)
                    {
                        var row = sheet.GetRow(startline);
                        if (row == null)
                        {
                            row = sheet.CreateRow(startline);
                        }

                        startline++;
                        var cell = GetCell(row, 0, modelrow);
                        cell.SetCellValue(qq.Number);
                    }
                }
            }
            return workbook;
        }

        public static string SaveTxtQQ(List<QQ> list,string remark)
        {
            var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Temps");
            if (!System.IO.Directory.Exists(folder))
            {
                System.IO.Directory.CreateDirectory(folder);
            }
            var txtFilePath = System.IO.Path.Combine(folder, remark.Replace(":","") + ".txt");
            if (System.IO.File.Exists(txtFilePath))
            {
                System.IO.File.Delete(txtFilePath);
            }
            using (var fs = new FileStream(txtFilePath, FileMode.OpenOrCreate))
            {
                using (var sw = new StreamWriter(fs))
                {
                    foreach (var item in list)
                    {
                        sw.WriteLine(item.Number);
                    }
                    sw.Flush();
                    sw.Close();
                }
                fs.Close();
            }


            return txtFilePath;
        }
        
    }
}