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
            Pet pet1 = new Pet
            {
                Kind = "Cat",
                Name = "Johny",
                Sex = 'M',
                Age = 4
            };
            Console.WriteLine($"Kind: {pet1.Kind}, Name: {pet1.Name},Sex: {pet1.Sex},Age: {pet1.Age}");
        }
    }
    public class Pet
    {
        public string Kind { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        private int age;
        public int Age
        {
           get
            {
                return age;
            }
            set
            {
                if(value > 0 && value < 100)
                {
                    age = value;
                }
            }
        }
        public string Description
        {
            get
            {
                return $"{Name} is a {Kind} ({Sex}) of {Age} years old.";
            }
        }
    }
}
