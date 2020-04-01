using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите сумму первоначального взноса в рублях");
                decimal sum = decimal.Parse(Console.ReadLine());
                int cht = 0;
                decimal procent = decimal.Parse(Console.ReadLine());
                int desired = int.Parse(Console.ReadLine());
                for (int i = 0; i < desired; i++)
                {
                    sum += procent;
                    cht++;
                }
                Console.WriteLine("Необходимое количество дней  для накопления желаемой суммы:{0} ", cht);
            }
            catch
            {
                Console.WriteLine("Некорректный ввод!");
            }
        }
    }
}
