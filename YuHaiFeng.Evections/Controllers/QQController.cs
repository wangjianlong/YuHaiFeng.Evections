using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuHaiFeng.Evections.Common;
using YuHaiFeng.Evections.Parameters;

namespace YuHaiFeng.Evections.Controllers
{
    public class QQController : ControllerBase
    {
        //
        // GET: /QQ/

        public ActionResult Index(string number=null,string remark=null, int page=1,int rows=20)
        {
            var parameter = new QQParameter
            {
                Number = number,
                Remark = remark,
                Page = new PageParameter(page, rows)
            };
            var list = Core.QQManager.Search(parameter);
            ViewBag.List = list;
            ViewBag.Parameter = parameter;

            ViewBag.Remarks = Core.QQManager.GetRemark();
            return View();
        }

        public ActionResult File()
        {
            return View();
        }



        [HttpPost]
        public ActionResult SaveFile(string remark)
        {
            if (Request.Files.Count == 0)
            {
                throw new ArgumentException("请选择上传文件");
            }
            var file = HttpContext.Request.Files[0];
            var fileName = file.FileName;
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("请上传文件");
            }
            var filePath = FileManager.Upload(file);
            var list = ExcelManager.AnalyzeQQ(filePath,remark);
            Core.QQManager.SaveRange(list);
            return RedirectToAction("Index");
        }

        public ActionResult Download(string remark)
        {
            var list = Core.QQManager.GetList(remark);
            IWorkbook workbook = ExcelManager.SaveQQ(list);
            MemoryStream ms = new MemoryStream();
            workbook.Write(ms);
            ms.Flush();
            byte[] fileContents = ms.ToArray();
            return File(fileContents, "application/ms-excel", remark+".xls");
        }
        public ActionResult DownloadTxt(string remark)
        {
            var list = Core.QQManager.GetList(remark);
            var file = ExcelManager.SaveTxtQQ(list,remark);
            return File(new FileStream(file, FileMode.Open), "text/plain", remark + ".txt");
        }
        

    }
}
