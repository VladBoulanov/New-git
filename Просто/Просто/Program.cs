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
            string s=null;
            do
            {
                if (s.Length <= 15)
                {
                    Console.WriteLine("Введите строку ");
                    s = Console.ReadLine();
                    Console.WriteLine("Entered string lenghtis {0}", s.Length);
                }
                else if (s.Length > 15)
                {
                    Console.WriteLine("Введите строку ");
                    s = Console.ReadLine();
                    Console.WriteLine("To long string.Try another");
                }continue;
            } while (s != "exit");
        }
    }
}
