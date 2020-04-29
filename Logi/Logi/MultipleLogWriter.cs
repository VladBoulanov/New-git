using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logi
{
    public class MultipleLogWriter : ILogWriter, IDisposable
    {
        protected ILogWriter[] _writers;

        public MultipleLogWriter(params ILogWriter[] writers)
        {
            _writers = writers;
        }

        public void LogError(string message)
        {
            foreach (ILogWriter writer in _writers)
            {
                writer.LogError(message);
            }
        }

        public void LogInfo(string message)
        {
            foreach (ILogWriter writer in _writers)
            {
                writer.LogInfo(message);
            }
        }

        public void LogWarning(string message)
        {
            foreach (ILogWriter writer in _writers)
            {
                writer.LogWarning(message);
            }
        }
        public void Dispose()
        {
            foreach (ILogWriter writer in _writers)
            {
                if (writer is IDisposable)
                {
                    ((IDisposable)writer).Dispose();
                }
            }
        }
    }
}
