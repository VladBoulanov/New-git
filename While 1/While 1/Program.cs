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
            var marks = new[]
            {
                new[]{2,3,3,2,3},
                new[]{2,4,5,3},
                null,
                new[]{5,5,5,5}
            };
            double sum = 0;
            double Sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] == null)
                {
                    Console.WriteLine("N/A");
                    continue;
                }

                for (int j = 0; j < marks[i].Length; j++)
                {
                    sum += marks[i][j];
                }
                Console.WriteLine($"Средний балл за день N{i + 1}=" + sum / marks[i].Length);
                Sum += sum / marks[i].Length;
            }
            Console.WriteLine($"Средний оценочный балл =" + Sum / marks.Length);
        }
    }
}
