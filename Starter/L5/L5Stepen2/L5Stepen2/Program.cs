using System;

namespace L5Stepen2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число -> ");

            string value = Console.ReadLine();
            int number = Convert.ToInt32(value);

            int result;
            result = number - 1;

            if ((number & result) == 0)
            {
                Console.WriteLine("Число является степенью двойки");
            }
            else
            {
                Console.WriteLine("Число НЕ является степенью двойки");
            }

            Console.ReadKey();
        }
    }
}
