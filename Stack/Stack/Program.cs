using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var scobcka = Console.ReadLine();            
            Stack<char> stack = new Stack<char>();
            for (int i = 0;i<scobcka.Length;i++)
            {
                    if(scobcka[i] == '(' ||  scobcka[i] == '[')
                    {
                        stack.Push(scobcka[i]);                        
                    }
                    else if(scobcka[i] == ')' ||  scobcka[i] == ']')
                    {
                        Console.WriteLine("var scobcka = {0} - False",scobcka[i]);                       
                    }

                else if (scobcka[i] == ')' || scobcka[i] == ']')
                {
                    var Spack = stack.Pop();
                    if (scobcka[i] == ')' && Spack == '(' || scobcka[i] == ']' && Spack == '[')
                    {
                        Console.WriteLine("var scobcka = {0} - True", scobcka[i]);
                    }
                    else
                    {
                        Console.WriteLine("var scobcka = {0} - False", scobcka[i]);
                    }
                }

               


            }

           
        }
    }
}
