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
            var s = Console.ReadLine();
            char[] s1 = s.ToCharArray(); 
            Stack<char> stack = new Stack<char>();
            for (int i = 0;i<s.Length;i++)
            {
                    if(s1[i] == '(' ||  s1[i] == '[')
                    {
                        stack.Push(s1[i]);                        
                    }

                else if (s1[i] == ')' || s1[i] == ']')
                {
                    var Sp = stack.Pop();
                    if (s1[i] == ')' && Sp == '(' || s1[i] == ']' && Sp == '[')
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }

               


            }

           
        }
    }
}
