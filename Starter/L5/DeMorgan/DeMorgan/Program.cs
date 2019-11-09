using System;

namespace DeMorgan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выражение до теоремы Де Моргана имело вид ' A || B ' ");
            Console.WriteLine();
            Console.WriteLine("После теоремы - ' !(!A && !B) '");

            Console.ReadKey();
        }
    }
}
