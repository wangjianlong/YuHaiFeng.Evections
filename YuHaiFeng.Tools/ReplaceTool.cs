using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace YuHaiFeng.Tools
{
    public class ReplaceTool:ITool
    {
        private string _sourceTxt { get; set; }
        public string SourceTxt { get { return _sourceTxt; } set { _sourceTxt = value; } }
        private string _key { get; set; }
        public string Key { get { return _key; }set { _key = value; } }
        private string _replaceFile { get; set; }
        public string ReplaceFile { get { return _replaceFile; } set { _replaceFile = value; } }
        private string _saveFile { get; set; }
        public string SaveFile { get { return _saveFile; }set { _saveFile = value; } }

        public void Program()
        {
            if (!System.IO.File.Exists(_replaceFile))
            {
                Console.WriteLine("替换文件不存在，请核对");
                return;
            }
            var txts = _replaceFile.ReadFile();
            if (txts.Count == 0)
            {
                Console.WriteLine("未读取到文本内容");
                return;
            }
            var list = new List<string>();
            foreach(var item in txts)
            {
                var temp = _sourceTxt;
                list.Add(temp.Replace(_key, item));
            }
            using (var fs=new FileStream(_saveFile, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var sw=new StreamWriter(fs))
                {
                    foreach (var item in list)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Flush();
                    sw.Close();
                }
                fs.Close();
            }

        }
    }
}
