//Завдання 6
//Користувач вводить з клавіатури показання температури.
//Залежно від вибору користувача, додаток конвертує
//температуру з Фаренгейта в Цельсій, або навпаки. 

using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.Write("Enter a temperature you want to transform: ");
            temp = int.Parse(Console.ReadLine());
            Console.WriteLine("\nMake your choice:\n\t1 - C to F\n\t2 - F to C");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Temperature " + temp + " C = " + ((temp * 9 / 5) + 32) + " F");
                    break;
                case 2:
                    Console.WriteLine("Temperature " + temp + " F = " + ((temp - 32) * 5 / 9) + " C");
                    break;
                default:
                    Console.WriteLine("Wrong number!");
                    break;
            }
        }
    }
}