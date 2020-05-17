using System;
using System.Collections.Generic;
using System.Text;

namespace Logging
{
    public static class ApplicationLog
    {
        private static Logger Logger { get; set; }

        public static void ConfigureLog(LogType logType = LogType.Console, string filePath = null, string fileName = null)
        {
            switch(logType)
            {
                case LogType.Console:
                    Logger = new ConsoleLogger();
                    break;
                case LogType.Debug:
                    Logger = new DebugLogger();
                    break;
                case LogType.File:
                    Logger = new FileLogger(filePath, fileName);
                    break;
                default:
                    Logger = new ConsoleLogger();
                    break;
            }
        }

        public static void WriteLog(LogLevel logLevel, string errorMessage, string additionalInfo = null)
        {
            Logger.WriteLog(logLevel, errorMessage, additionalInfo);
        }
    }
}
