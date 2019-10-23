using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 13;
            var c = 51;
            int result;

            result = ((a + b + c) / 3);

            Console.Write("Результат : ");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
