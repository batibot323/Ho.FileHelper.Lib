using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ho.FileHelper.Lib
{
    public static class FileHelper
    {
        public static string SolutionFolder()
        {
            DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return directory.FullName.ToString();
        }

        public static string AppendDateTime(string fileName)
        {
            string appendedFileName = $"{fileName}{ DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") }.txt";
            return appendedFileName;
        }

        public static string GenerateFilePath(string folderName, string fileName)
        {
            string generatedFilePath = Path.Combine(SolutionFolder(), folderName, AppendDateTime(fileName));
            return generatedFilePath;
        }
    }
}
