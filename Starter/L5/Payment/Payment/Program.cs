using System;

namespace Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;

            x += y >> x++ * z;
            Console.WriteLine("Выражение 'x += y >> x++ * z' имеет такой результат x={0} y={1} z={2}", x, y, z);
            Console.WriteLine("");

            z = ++x & y * 5;
            Console.WriteLine("Выражение 'z = ++x & y * 5' имеет такой результат x={0} y={1} z={2}", x, y, z);
            Console.WriteLine("");

            y /= x + 5 | z;
            Console.WriteLine("Выражение 'y /= x + 5 | z' имеет такой результат x={0} y={1} z={2}", x, y, z);
            Console.WriteLine("");

            z = x++ & y * 5;
            Console.WriteLine("Выражение 'z = x++ & y * 5' имеет такой результат x={0} y={1} z={2}", x, y, z);
            Console.WriteLine("");

            x = y << x++ ^ z;
            Console.WriteLine("Выражение 'x = y << x++ ^ z' имеет такой результат x={0} y={1} z={2}", x, y, z);

            Console.ReadKey();
        }
    }
}
