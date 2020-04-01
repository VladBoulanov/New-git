using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            var s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            var s2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(s1 + "+" + s2 + "=" + s1 + s2);
            Console.WriteLine(String.Format("{0}+{1}={2}", s1, s2, s1 + s2));
            Console.WriteLine($"{s1}-{s2}={s1 - s2}");
        }
    }
}
