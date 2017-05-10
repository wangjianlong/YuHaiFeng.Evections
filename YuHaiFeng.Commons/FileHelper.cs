using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YuHaiFeng.Commons
{
    public static class FileHelper
    {
        public static string OpenFile(string title,string filter,string startPath = null)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = title;
            dialog.Filter = filter;
            dialog.InitialDirectory = startPath;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return string.Empty;
        }
        public static string SelectFolder(string startPath = null)
        {
            FolderBrowserDialog folderBrowseDialog = new FolderBrowserDialog();
            folderBrowseDialog.SelectedPath = startPath;
            if (folderBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                return folderBrowseDialog.SelectedPath;
            }
            return string.Empty;
        }
        public static string SaveFile(string filter, string title, string startPath = null)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = startPath;
            saveFileDialog.Filter = filter;
            saveFileDialog.Title = title;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            return string.Empty;
        }
        public static List<string> GetSpecialFiles(string folder, string filter)
        {
            var dir = new DirectoryInfo(folder);
            var files = dir.GetFiles(filter);
            return files.Select(e => e.FullName).ToList();
        }
        
    }
}
