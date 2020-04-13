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
                Kind ="Cat";
                pet1.Name = "Johny";
                pet1.Sex = 'M';
                pet1.Age = 4;
            }
        }
    }
    public class Pet
    {
        public string Kind ;
        public string Name;
        public char Sex;
        public int Age;
    }
}
