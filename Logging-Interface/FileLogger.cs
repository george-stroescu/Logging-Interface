using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logging
{
    class FileLogger : Logger
    {
        private string FilePath { get; }
        private string FileName { get; }

        string FullPath { get; set; }

        public FileLogger(string filePath = null, string fileName = null)
        {
            if (!String.IsNullOrWhiteSpace(filePath))
            {
                FilePath = filePath;
            }
            else
            {
                //FilePath = "C:\\Users\\Public\\Documents";
                //FilePath = "C:\\Users\\Public\\Desktop";
                FilePath = Path.GetTempPath();
            }

            if (!String.IsNullOrWhiteSpace(fileName))
            {
                FileName = fileName;
            }
            else
            {
                FileName = "ErrorLog.txt";
            }

            ConfigurePath();
        }

        private void ConfigurePath()
        {
            FullPath = Path.Combine(FilePath, FileName);
        }

        public void WriteLog(LogLevel logLevel, string errorMessage, string additionalInfo = null)
        {
            using (StreamWriter sw = new StreamWriter(FullPath))
            {
                sw.WriteLine($"{logLevel}: {errorMessage}");

                if (!String.IsNullOrWhiteSpace(additionalInfo))
                {
                    sw.WriteLine(additionalInfo);
                }
            }
        }
    }
}
