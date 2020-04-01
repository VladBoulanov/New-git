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
            string text = " lprem impast  oufd  dollar  ";
            text = text.Trim();
            Console.WriteLine(text);
            text = text.Substring(15);
            Console.WriteLine(text);
            text = text.Substring(21);
            Console.WriteLine(text);
            string text1 = text.Substring(6);
            string text2 = text1.Substring(0, text.Length - 14);
            Console.WriteLine(text2.ToUpper());
        }
    }
}
