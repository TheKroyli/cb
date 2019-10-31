using  System;

namespace L4Сalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int op1 = 5;
            int op2 = 0;

            Console.WriteLine("Первое число = {0}", op1);
            Console.WriteLine("Второе число = {0}", op2);
            Console.WriteLine("Введите знак арифметической операции : ");

            string sigh = Console.ReadLine();

            int decision;

            Console.ReadKey();
            switch (sigh)
            {
                case "+":
                    decision = op1 + op2;
                    Console.Write(decision);
                    break;

                case "-":
                    decision = op1 - op2;
                    Console.Write(decision);
                    break;

                case "*":
                    decision = op1 * op2;
                    Console.Write(decision);
                    break;

                case "/":
                    if (op1 == 0)
                    {
                        Console.WriteLine("Первое число = 0, на 0 делить нельзя");
                        Console.ReadKey();
                        return;
                    }
                    else if (op2 == 0)
                    {
                        Console.WriteLine("Второе число = 0, на 0 делить нельзя");
                        Console.ReadKey();
                        return;
                    }
                    decision = op1 / op2;
                    Console.Write(decision);
                    break;
            }

            Console.ReadKey();
        }
    }
}
