using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    public class ConsoleLogWriter: ILogWriter, IDisposable
    {
        public ConsoleLogWriter()
        {
        }

        private const string _logFormat = "{0:yyyy-MM-ddThh:mm:ss}+000\t{1}\t{2}";


        public void LogError(string message)
        {
            LogRecord(GetRecord(message, LogLevel.Error));
        }

        public void LogInfo(string message)
        {
            LogRecord(GetRecord(message, LogLevel.Info));
        }

        public void LogWarning(string message)
        {
            LogRecord(GetRecord(message, LogLevel.Warning));
        }
        private string GetRecord(string message, LogLevel level)
        {
            return string.Format(_logFormat, DateTime.Now, level, message);
        }
        public void LogRecord(string message)
        {
            Console.WriteLine(message);

        }

        public void Dispose()
        {
        }
    }
}
