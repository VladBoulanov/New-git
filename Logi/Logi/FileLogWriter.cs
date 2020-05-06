using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    public enum LogLevel { Info, Warning, Error }
    public class FileLogWriter : ILogWriter, IDisposable
    {
        private StreamWriter _writer;

        public FileLogWriter(string logFile = "log.txt")
        {
            _writer = new StreamWriter(File.Open(logFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read));
            _writer.BaseStream.Seek(0, SeekOrigin.End);
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
            _writer.WriteLine(message);
            _writer.Flush();
        }

        public void Dispose()
        {
            if (_writer != null)
            {
                _writer.Dispose();
            }
        }
       
            private static FileLogWriter instance;

            private FileLogWriter() { }

            public static FileLogWriter GetInstance()
            {
                if (instance == null)
                    instance = new FileLogWriter();
                return instance;
            }
        
    }
}
