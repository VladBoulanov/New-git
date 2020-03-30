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
            int[] mass = new int[5] { 1, 2, 3, 4, 5 };
            int sum=0;
            while(sum<mass.Length)
            {
                sum +=mass[4];
            }

        }
    }
}
