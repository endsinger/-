using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULearn
{
    class Class1
    {
        public static void GetDiscriminant(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"Дискриминант равен: {d}");
            
            if (d < 0)
            {
                Console.WriteLine("корней нет");
            } 
            else if (d == 0){
                double ifZero = -b / (2 * a);
                Console.WriteLine("Один корень равный: " + ifZero);
            } 
            else if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x1 = Math.Round(x1, 3);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = Math.Round(x2, 3);
                Console.WriteLine($"Первый корень равен: {x1}, второй корень равен: {x2}");
            }
        }

    }
}
