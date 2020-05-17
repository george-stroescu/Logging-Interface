using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Logging
{
    class DebugLogger : Logger
    {
        public void WriteLog(LogLevel logLevel, string errorMessage, string additionalInfo = null)
        {
            Debug.WriteLine($"{logLevel}: {errorMessage}");

            if (!String.IsNullOrWhiteSpace(additionalInfo))
            {
                Debug.WriteLine($"{additionalInfo}");
            }
        }
    }
}
