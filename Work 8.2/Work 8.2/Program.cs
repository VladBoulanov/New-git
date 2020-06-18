using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите непустую строку: ");
            var text = Console.ReadLine();
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Вы ввели пустую строку :( Попробуйте ещё раз: ");
            }
            else
            {
                char[] words = text.Reverse().ToArray();
                string word1 = new string(words);
                Console.WriteLine(word1.ToLower());
            }
            
        }
    }
}
