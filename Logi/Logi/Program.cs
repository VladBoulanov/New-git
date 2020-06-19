using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logi
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogWriter singletone = ConsoleLogWriter.Instance;
            FileLogWriter singletone1 = FileLogWriter.Instance;
            using (var fl = new MultipleLogWriter(singletone, singletone1))
            {
                fl.LogInfo("Info message");
                Thread.Sleep(40);
                fl.LogWarning("Warning message");
                Thread.Sleep(350);
                fl.LogError("Error message");
            }
        }
    }
}
