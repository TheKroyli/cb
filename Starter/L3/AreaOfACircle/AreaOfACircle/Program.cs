using System;

namespace AreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141;
            double r = 6;
            int stepen = 2;
            double result;

            result = pi * Math.Pow(6, stepen);

            Console.Write("Радиус круга равен : ");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
