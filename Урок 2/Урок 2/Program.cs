using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имена");
            string[] names = new string[3];
            int[] age = new int[3];
            names[0] = Console.ReadLine();
            names[1] = Console.ReadLine();
            names[2] = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            age[0] = int.Parse(Console.ReadLine());
            age[1] = int.Parse(Console.ReadLine());
            age[2] = int.Parse(Console.ReadLine());
            for(int i = 0; i < names.Length; i++)
            {
                age[i] += 4;
                Console.WriteLine("Name:{0},age in 4 years:{1}", names[i], age[i]);
            }
           Console.ReadKey();
        }
    }
}
