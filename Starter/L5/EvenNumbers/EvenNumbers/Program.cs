using System;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Метод №1");
            Console.WriteLine("Введите число");
            string M1number1 = Console.ReadLine();
            int M1number = int.Parse(M1number1);

            int result = M1number & 1;

            if (result == 0)
            {
                Console.WriteLine("Число четное");
            }

            else
            {
                Console.WriteLine("Число НЕчетное");
            }

            Console.ReadKey();

            Console.WriteLine("");

            Console.WriteLine("Метод №2");
            Console.WriteLine("Введите число");
            string M2number1 = Console.ReadLine();
            int M2number = int.Parse(M2number1);

            if (M2number % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }

            else
            {
                Console.WriteLine("Число НЕчетное");
            }

            Console.ReadKey();
        }
    }
}
