using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingProject1
{
    internal class FileDiscription
    {
        public void GetFileDescription(String currentDirectory)
        {
            string[] filePaths = Directory.GetFiles(currentDirectory);
            Dictionary<String, String> fileDescription = new Dictionary<String, String>();
            foreach (string filePath in filePaths)
            {
                string fileName = Path.GetFileName(filePath);
                string fileType = Path.GetExtension(filePath);
                long fileSize = fileName.Length;
                Console.WriteLine($"FileName: {fileName}-------Filetype: {fileType}-------Filesize: {fileSize}");
            }
        }
    }
}
