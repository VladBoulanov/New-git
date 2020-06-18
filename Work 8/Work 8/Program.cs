using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            var test = Console.ReadLine();
            string[] array = test.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            int cht = 0;
            int count = test.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length;
            foreach (string str in array)
            {
               if(count < 2)
                {
                    Console.WriteLine(" Слишком мало слов :( Попробуйте ещё раз: ");
                }
                else if (count >= 2)
                {
                    if (str.StartsWith("А") || str.StartsWith("а"))
                    {
                        cht++;
                    }
                 else
                    {
                        Console.WriteLine("Нет таких слов");
                    }
                }
            }
            Console.WriteLine("Количество слов, начинающихся с буквы 'А': {0}",cht);
        }
    }
}
