using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)

        {
            double pi = 3.141592653;
            decimal e;
            e = 2.7182818284590452M;

            string a = "\nмоя строка 1";
            string b = "\tмоя строка 2";
            string c = "\aмоя строка 3";

            Console.WriteLine(pi);
            Console.WriteLine(e);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
