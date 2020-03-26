using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_3
{
    [Flags]
    public enum Type
        {
          volume1=0001,
          volume5=0010,
          volume20=0100
        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой объем сока (в литрах) требуется упаковать?");
            double v = double.Parse(Console.ReadLine());
            Console.WriteLine("Вам потребуются следующие контейнеры: ");
            int v20 = (int)v / 20;
            int v5 = (int)(v - v20 * 20) / 5 ;
            int v3 = (int)(v - v20 * 20 - v5 * 5);
            int presence = 0;
            if (v3 > 0)
            {
                presence |= (int)Type.volume1;
            }
            if (v5 > 0)
            {
                presence |= (int)Type.volume5;
            }
            if (v20 > 0)
            {
                presence |= (int)Type.volume20;
            }
            Console.WriteLine("Вам потребуются следующие контейнеры:");
            if ((presence & (int)Type.volume20) != 0)
            {
                Console.WriteLine("20 л: {0} шт.", v20);
            }
            if ((presence & (int)Type.volume5) != 0)
            {
                Console.WriteLine("5 л: {0} шт.", v5);
            }
            if ((presence & (int)Type.volume1) != 0)
            {
                Console.WriteLine("1 л: {0} шт.", v3);
            }
            else
            {
                Console.WriteLine("Ошибка ввода, до свидания!");
            }
        }
           
}
    
}
