using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Просто
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
    public class BaseDocument
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public DateTimeOffset IssueDate { get; set; }
        public string Description { get; }
        public void WriteToConsole()
        {
            Console.WriteLine(Description);
        }
    }
    public class Passport:BaseDocument
    {
        public string Country { get; set; }
        public string PersonName { get; set; }
        public string newDescription { get; }
        public void newWriteToConsole()
        {
            Console.WriteLine(Description);
        }
    }
}
