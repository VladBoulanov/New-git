using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    enum Type
    {
        Circle=1,
        Triangle=2,
        Rectangle=3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите тип фигуры");
            int a = int.Parse(Console.ReadLine());
            if(a==1)
            {
                try
                {
                    Console.WriteLine("Введите диаметр круга");
                    var dia = double.Parse(Console.ReadLine());
                    var Sc = (3.14 * Math.Pow(dia / 2, 2));
                    var Pc = 2 * 3.14 * (dia / 2);
                    Console.WriteLine("Площадь поверхности: {0}", Sc);
                    Console.WriteLine("Длина периметра: {0}", Pc);
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                }
            }
            else if (a == 2)
            {
                try
                {
                    Console.WriteLine("Введите длину стороны");
                    var side = double.Parse(Console.ReadLine());
                    var h = Math.Sqrt(3) * side / 2;
                    var St = h * side / 2;
                    var Pt = side * 3;
                    Console.WriteLine("Площадь поверхности: {0}", St);
                    Console.WriteLine("Длина периметра: {0}", Pt);
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                }
            }
            else if (a == 3)
            {
                try
                {
                    Console.WriteLine("Введите длину прямоугольника");
                    var width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите высоту прямоугольника");
                    var heigh = double.Parse(Console.ReadLine());
                    var Sr = width * heigh;
                    var Pr = width * 2 + heigh * 2;
                    Console.WriteLine("Площадь поверхности: {0}", Sr);
                    Console.WriteLine("Длина периметра: {0}", Pr);
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                }
            }
        }
    }
}
