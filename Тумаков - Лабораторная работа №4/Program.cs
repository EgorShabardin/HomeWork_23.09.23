using System;

namespace Тумаков___Лабораторная_работа__4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Упражнение №4.1. Программа получает число и возвращает соответсвующий месяц и день недели.
            Console.WriteLine("{0,102}", "УПРАЖНЕНИЕ 4.1. ПРОГРАММА ПОЛУЧАЕТ ЧИСЛО И ВОЗВРАЩАЕТ СООТВЕТСВУЮЩИЙ МЕСЯЦ И ДЕНЬ НЕДЕЛИ\n");

            try
            {
                int day;

                Console.Write("Введите номер дня (от 1 до 365): ");
                day = int.Parse(Console.ReadLine());

                DateTime dateTime = new DateTime(2023, 1, 1).AddDays(day - 1);

                switch (dateTime.Month)
                {
                    case 01:
                        Console.WriteLine($"{dateTime.Day} Января");
                        break;
                    case 02:
                        Console.WriteLine($"{dateTime.Day} Февраля");
                        break;
                    case 03:
                        Console.WriteLine($"{dateTime.Day} Марта");
                        break;
                    case 04:
                        Console.WriteLine($"{dateTime.Day} Апреля");
                        break;
                    case 05:
                        Console.WriteLine($"{dateTime.Day} Мая");
                        break;
                    case 06:
                        Console.WriteLine($"{dateTime.Day} Июня");
                        break;
                    case 07:
                        Console.WriteLine($"{dateTime.Day} Июля");
                        break;
                    case 08:
                        Console.WriteLine($"{dateTime.Day} Августа");
                        break;
                    case 09:
                        Console.WriteLine($"{dateTime.Day} Сентября");
                        break;
                    case 10:
                        Console.WriteLine($"{dateTime.Day} Октября");
                        break;
                    case 11:
                        Console.WriteLine($"{dateTime.Day} Ноября");
                        break;
                    case 12:
                        Console.WriteLine($"{dateTime.Day} Декабря");
                        break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не число или оно не является целым!");
            }


            // Упражнение 4.2. Программа из Упражнения 4.1, но при неврном числе вырабатывается исключение.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,104}", "УПРАЖНЕНИЕ 4.2. ПРОГРАММА ИЗ УПРАЖНЕНИЯ 4.1, НО ПРИ НЕВЕРНОМ ЧИСЛЕ ВЫРАБАТЫВАЕТСЯ ИСКЛЮЧЕНИЕ\n");

            try
            {
                int day;

                Console.Write("Введите номер дня (от 1 до 365): ");
                day = int.Parse(Console.ReadLine());

                if ((day < 1) || (day > 365))
                {
                    throw new Exception("Вы ввели число меньше 1 или больше 365");
                }

                DateTime dateTime = new DateTime(2023, 1, 1).AddDays(day - 1);

                switch (dateTime.Month)
                {
                    case 01:
                        Console.WriteLine($"{dateTime.Day} Января");
                        break;
                    case 02:
                        Console.WriteLine($"{dateTime.Day} Февраля");
                        break;
                    case 03:
                        Console.WriteLine($"{dateTime.Day} Марта");
                        break;
                    case 04:
                        Console.WriteLine($"{dateTime.Day} Апреля");
                        break;
                    case 05:
                        Console.WriteLine($"{dateTime.Day} Мая");
                        break;
                    case 06:
                        Console.WriteLine($"{dateTime.Day} Июня");
                        break;
                    case 07:
                        Console.WriteLine($"{dateTime.Day} Июля");
                        break;
                    case 08:
                        Console.WriteLine($"{dateTime.Day} Августа");
                        break;
                    case 09:
                        Console.WriteLine($"{dateTime.Day} Сентября");
                        break;
                    case 10:
                        Console.WriteLine($"{dateTime.Day} Октября");
                        break;
                    case 11:
                        Console.WriteLine($"{dateTime.Day} Ноября");
                        break;
                    case 12:
                        Console.WriteLine($"{dateTime.Day} Декабря");
                        break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не число или оно не является целым!");
            }
            catch (Exception dateException)
            {
                Console.WriteLine(dateException.Message);
            }


            // Домашнее задание 4.1. Программа из Упражнения 4.1 и Упражнения 4.2, но учитывается високосный год.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 107}", "ДОМАШНЕЕ ЗАДАНИЕ 4.1. ПРОГРАММА ИЗ УПРАЖНЕНИЯ 4.1 И УПРАЖНЕНИЯ 4.2, НО УЧИТЫВАЕТСЯ ВИСОКОСНЫЙ ГОД\n");

            try
            {
                int yearDays, day;
                int year = 2023;

                Console.Write("Введите количество дней в году: ");
                yearDays = int.Parse(Console.ReadLine());
                Console.Write($"Введите номер дня (от 1 до {yearDays}): ");
                day = int.Parse(Console.ReadLine());

                if ((yearDays != 366) && (yearDays != 365))
                {
                    throw new Exception($"В году не может быть {yearDays} дней!");
                }

                if ((day < 1) || (day > yearDays))
                {
                    throw new Exception($"Вы ввели число меньше 1 или больше {yearDays}");
                }

                if (yearDays % 5 != 0)
                {
                    year += 1;
                }

                DateTime dateTime = new DateTime(year, 1, 1).AddDays(day - 1);

                switch (dateTime.Month)
                {
                    case 01:
                        Console.WriteLine($"{dateTime.Day} Января");
                        break;
                    case 02:
                        Console.WriteLine($"{dateTime.Day} Февраля");
                        break;
                    case 03:
                        Console.WriteLine($"{dateTime.Day} Марта");
                        break;
                    case 04:
                        Console.WriteLine($"{dateTime.Day} Апреля");
                        break;
                    case 05:
                        Console.WriteLine($"{dateTime.Day} Мая");
                        break;
                    case 06:
                        Console.WriteLine($"{dateTime.Day} Июня");
                        break;
                    case 07:
                        Console.WriteLine($"{dateTime.Day} Июля");
                        break;
                    case 08:
                        Console.WriteLine($"{dateTime.Day} Августа");
                        break;
                    case 09:
                        Console.WriteLine($"{dateTime.Day} Сентября");
                        break;
                    case 10:
                        Console.WriteLine($"{dateTime.Day} Октября");
                        break;
                    case 11:
                        Console.WriteLine($"{dateTime.Day} Ноября");
                        break;
                    case 12:
                        Console.WriteLine($"{dateTime.Day} Декабря");
                        break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не число или оно не является целым!");
            }
            catch (Exception dateException)
            {
                Console.WriteLine(dateException.Message);
            }
        }
    }
}
