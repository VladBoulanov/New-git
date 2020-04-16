using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nage
{
    public class Persone
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private int _age4;
        public int Age4
        {
            get
            {
                return _age4=Age+4;
            }

        }
        public string Description
        {
            get
            {
                return $"Name:{Name}, age in 4 years: {Age4},";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Persone[3];

            for (var i = 0;i < persons.Length;i++)
            {
                persons[i]=new Persone();
                Console.Write($"Enter name {i}:");
                persons[i].Name = Console.ReadLine();
                Console.Write($"Enter age {i}:");
                persons[i].Age = int.Parse(Console.ReadLine());
            }
            foreach(var person in persons)
            {
                Console.WriteLine(person.Description);
            }
            Console.ReadKey();
        }
    }
}
