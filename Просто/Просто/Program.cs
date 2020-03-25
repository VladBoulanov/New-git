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
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            if(a==1 || a==21|| a == 31 || a == 41 || a == 51 || a == 61 || a == 71 || a == 81 || a == 91 )
            {
                Console.WriteLine("год");
            }
           else if(a >= 2 && a<=4 || a>=22 && a <= 24 || a>=32 && a <= 34 || a>=42 && a <= 44 || a>=52 && a <= 54 || a>=62 && a <= 64 || a>=72 && a <= 74 || a>=82 && a <= 84 || a>=92 && a <= 94  )
            {
                Console.WriteLine("года");
            }
            else if(a==5 || a == 6 || a == 7 || a == 8 || a == 9 || a == 10 || a == 11 || a == 12 || a == 13 || a == 14 || a == 15 || a == 16 || a == 17 || a == 18 || a == 19 || a == 20)
            {
                Console.WriteLine("лет");
            }
        }
    }
}
