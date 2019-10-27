using System;
using System.Resources;

namespace СalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число -> ");
            string operand1 = Console.ReadLine();
            int op1 = Convert.ToInt32(operand1);

            Console.WriteLine("Введите второе число -> ");
            string operand2 = Console.ReadLine();
            int op2 = Convert.ToInt32(operand2);

            Console.WriteLine("Введите знак арифметической операции : ");

            string sigh = Console.ReadLine();

            int decision = 0;

           
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
                    decision = op1 / op2;
                    Console.Write(decision);
                    break;
            }

            Console.ReadKey();
        }
    }
}
