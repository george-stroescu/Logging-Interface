using System;
using System.Collections.Generic;
using System.Text;

namespace Logging
{
    public interface Logger
    {
        void WriteLog(LogLevel logLevel, string errorMessage, string additionalInfo = null);
    }
}
