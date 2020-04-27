using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposble
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ErrorList:IDisposable
    {
        public string Category { get; }
        public List<string> Errors { get; set; }
        public ErrorList(string category,List<string> errors)
        {
            Category = category;
            Errors = errors;
        }
        public void Dispose()
        {
            Errors.Clear();

        }
    }
}
