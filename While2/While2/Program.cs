using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите натуральное число:");
                int a = int.Parse(Console.ReadLine());
                int cht = 0;
                while (a > 0)
                {
                    int b = a % 10;
                    if (b % 2 == 0)
                    {
                        cht++;
                    }
                    a = a / 10;
                }
                Console.WriteLine("В числе a содержится следующее количество четных цифр:{0}", cht);
            }
            catch
            {
                Console.WriteLine(" Ошибка System.OverflowException! Попробуйте ещё раз: ");
            }
        }
    }
}
