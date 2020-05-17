using System;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            // Optional: Set path and file name for File Logger
            ApplicationLog.ConfigureLog(LogType.File);

            int x = 1;
            int y = 0;

            try
            {
                Console.WriteLine(x / y);
            }
            catch (Exception ex)
            {
                ApplicationLog.WriteLog(LogLevel.Critical, ex.Message, ex.StackTrace);
            }
        }
    }
}
