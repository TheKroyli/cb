using System;

namespace L4Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово на русском ");

            string transfer = Console.ReadLine();

            switch (transfer)
            {
                case "дождь":
                    Console.WriteLine("Перевод слова {0} -> rain", transfer);
                    break;

                case "холод":
                    Console.WriteLine("Перевод слова {0} -> cold", transfer);
                    break;

                case "ветер":
                    Console.WriteLine("Перевод слова {0} -> wind", transfer);
                    break;

                case "жара":
                    Console.WriteLine("Перевод слова {0} -> heat", transfer);
                    break;

                case "туман":
                    Console.WriteLine("Перевод слова {0} -> fog", transfer);
                    break;

                case "снег":
                    Console.WriteLine("Перевод слова {0} -> snow", transfer);
                    break;

                case "прохладный":
                    Console.WriteLine("Перевод слова {0} -> cool", transfer);
                    break;

                case "ливень":
                    Console.WriteLine("Перевод слова {0} -> shower", transfer);
                    break;

                case "молния":
                    Console.WriteLine("Перевод слова {0} -> lightning", transfer);
                    break;

                case "град":
                    Console.WriteLine("Перевод слова {0} -> hail", transfer);
                    break;
            }

            Console.ReadKey();
        }
    }
}
