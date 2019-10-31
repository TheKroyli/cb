using System;

namespace L4Fo0To100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число :");

            string number1 = Console.ReadLine();

            int Number = Convert.ToInt32(number1);

            if (Number >= 0 && Number <= 14)
            {
                Console.WriteLine("Вы ввели {0}, числовой промежуток от 0 до 14", Number);
            }
            else if (Number >= 15 && Number <= 35)
            {
                Console.WriteLine("Вы ввели {0}, числовой промежуток от 15 до 35", Number);
            }
            else if (Number >= 36 && Number <= 50)
            {
                Console.WriteLine("Вы ввели {0}, числовой промежуток от 36 до 50", Number);
            }
            else if (Number >= 50 && Number <= 100)
            {
                Console.WriteLine("Вы ввели {0}, числовой промежуток от 50 до 100", Number);
            }
            else
            {
                Console.WriteLine("Данное число не входит не в один числовой промежуток");
            }

            Console.ReadKey();
        }
    }
}
