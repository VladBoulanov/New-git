using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип операции");
            char v = char.Parse(Console.ReadLine());
            if(v=='+')
            {
                Console.WriteLine(a+b);
            }
            else if (v == '-')
            {
                Console.WriteLine(a-b);
            }
            else if (v == '*')
            {
                Console.WriteLine(a*b);
            }
            else if (v == '/')
            {
                Console.WriteLine(a/b);
            }
            else if (v == '%')
            {
                Console.WriteLine(a%b);
            }
            else if (v == '^')
            {
                Console.WriteLine(Math.Pow(a,b));
            }
            Console.ReadKey();
        }
    }
}
