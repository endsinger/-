using System;

namespace ULearn
{
    class Program
    {      
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("========================== \n \n Программа решения квадратного уравнения \n Введиет значения переменных a, b, c");
                try
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    Class1.GetDiscriminant(a, b, c);
                }
                catch
                {
                    Console.WriteLine("Ошибка, введеные данные некорректны");
                }
            }
        }

    }

}
