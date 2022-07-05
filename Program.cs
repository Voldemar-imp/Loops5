using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rub;
            float usd;
            float cny;
            float rubToUsd = 0.017f;
            float rubToCny = 0.112f;
            float usdToRub = 58.51f;
            float usdToCny = 6.54f;
            float cnyToRub = 8.95f;
            float cnyToUsd = 0.153f;
            string userInput = "0";
            float currencyCount;

            Console.WriteLine("Добро пожаловть в путнкт обмена валют!");
            Console.WriteLine("Здесь можно обменять рубли, доллары и юани");
            Console.Write("Введите количество рублей у вас на счету: ");
            rub = Convert.ToSingle (Console.ReadLine());
            Console.Write("Введите количество долларов у вас на счету: ");
            usd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите количество юаней у вас на счету: ");
            cny = Convert.ToSingle(Console.ReadLine());

            while (userInput != "9")
            {
                Console.Write("Нажмите - 1, если хотите обменять рубли на доллары \n" +
                    "Нажмите - 2, если хотите обменять рубли на юани \n" +
                    "Нажмите - 3, если хотите обменять доллары на рубли \n" +
                    "Нажмите - 4, если хотите обменять доллары  на юани \n" +
                    "Нажмите - 5, если хотите обменять юани на рубли \n" +
                    "Нажмите - 6, если хотите обменять юани на доллары \n" +
                    "Нажмите - 9, если хотите покинуть пункт обмена валюты  ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "9":
                        break;
                    case "1":
                        Console.Write ("Сколько хотите обменять рублей на доллары: ");
                        currencyCount = Convert.ToSingle (Console.ReadLine());

                        if (currencyCount <= rub)
                        {
                            rub -= currencyCount;
                            usd += currencyCount*rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно рублей для обмена");
                        }
                        break;
                    case "2":
                        Console.Write("Сколько хотите обменять рублей на юани: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (currencyCount <= rub)
                        {
                            rub -= currencyCount;
                            cny += currencyCount * rubToCny;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно рублей для обмена");
                        }
                        break;
                    case "3":
                        Console.Write("Сколько хотите обменять долларов на рубли: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (currencyCount <= usd)
                        {
                            usd -= currencyCount;
                            rub += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно долларов для обмена");
                        }
                        break;
                    case "4":
                        Console.Write("Сколько хотите обменять долларов на юани: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (currencyCount <= usd)
                        {
                            usd -= currencyCount;
                            cny += currencyCount * usdToCny;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно долларов для обмена");
                        }
                        break;
                    case "5":
                        Console.Write("Сколько хотите обменять юаней на рубли: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (currencyCount <= cny)
                        {
                            cny -= currencyCount;
                            rub += currencyCount * cnyToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно юаней для обмена");
                        }
                        break;
                    case "6":
                        Console.Write("Сколько хотите обменять юаней на доллары: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (currencyCount <= cny)
                        {
                            cny -= currencyCount;
                            usd += currencyCount * cnyToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно юаней для обмена");
                        }
                        break;
                        default:
                        Console.WriteLine("Неверно введена команда, поробуйте еще раз");
                        break;
                }

                Console.WriteLine("На ващем счету {0} - рублей, {1} - доларов, {2} - юаней.", rub, usd, cny);
                Console.ReadKey();
            }

            Console.WriteLine("Благодарим за визит, хорошего дня!");
        }
    }
}
