using System;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141;
            double V = 3, S = 14, R = 12, h = 8, _volume, area;
            double stepen = 2;


            _volume = pi * Math.Pow(R, stepen) * h;
            area = (2 * pi * Math.Pow(R, stepen) * h) + (2 * pi * Math.Pow(R, stepen) * h);
            area = 2 * pi * R * ((R + h));

            Console.Write("Объем равен : ");
            Console.WriteLine(_volume);

            Console.Write("Площадь  равен : ");
            Console.WriteLine(area);

            Console.ReadKey();


        }
    }
}
