using System;

namespace Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число клиентов");
            string customersS = Console.ReadLine();
            int customers = Int32.Parse(customersS);

            int factorial = 1;

            do
            { 
                factorial *= customers--;
            }
            while (customers > 0);

            Console.WriteLine("Для {0} клиентов имеется {1} маршрута", customersS, factorial);

            Console.ReadKey();
        }
    }
}
