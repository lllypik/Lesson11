using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты В и К из уравнения k*Х + b = 0");
            double coeffB = Convert.ToDouble(Console.ReadLine());
            double coeffK = Convert.ToDouble(Console.ReadLine());

            Linear equation = new Linear(coeffB, coeffK);

            Console.WriteLine("Решение данного уравнения: Х = {0} \n{1}", equation.Root(), equation.Note ());
            Console.ReadKey();

        }
    }
}

