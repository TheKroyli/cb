using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите зарплату сотрудника");
            string zarplata1 = Console.ReadLine();
            int zarplata;
            zarplata = int.Parse(zarplata1);
            Console.WriteLine("");

            Console.WriteLine("Введите стаж сотрудника");
            string stag1 = Console.ReadLine();
            int stag;
            stag = int.Parse(stag1);
            Console.WriteLine("");

            double result;

            if (stag < 5)
            {
                result = (zarplata * 0.10);
                Console.WriteLine("Премия сотрудника равна {0}", result);
            }

            else if (stag >= 5 && stag < 10)
            {
                result = (zarplata * 0.15);
                Console.WriteLine("Премия сотрудника равна {0}", result);
            }

            else if (stag >= 10 && stag < 15)
            {
                result = (zarplata * 0.25);
                Console.WriteLine("Премия сотрудника равна {0}", result);
            }

            else if (stag >= 15 && stag < 20)
            {
                result = (zarplata * 0.35);
                Console.WriteLine("Премия сотрудника равна {0}", result);
            }

            else if (stag >= 20 && stag < 25)
            {
                result = (zarplata * 0.45);
                Console.WriteLine("Премия сотрудника равна {0}", result);
            }

            else if (stag >= 25)
            {
                result = (zarplata * 0.50);
                Console.WriteLine("Премия сотрудника равна {0}", result);
            }

            Console.ReadKey();
        }
    }
}
