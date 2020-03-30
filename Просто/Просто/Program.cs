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
                Console.WriteLine("Введите строку ");
                s = Console.ReadLine();
            } while (s != "exit");
        }
    }
}
