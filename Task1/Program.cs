using System;
/*Завдання 1
Користувач вводить з клавіатури число від 1 до 100.
Якщо число кратне 3 (ділиться на 3 без залишку), потрібно
вивести слово Fizz. Якщо число кратне 5, потрібно вивести
слово Buzz. Якщо число кратне 3 і 5, потрібно вивести Fizz
Buzz. Якщо число не кратне ні 3, ані 5, потрібно вивести
тільки число.
Якщо користувач ввів значення не в діапазоні від 1
до 100, потрібно вивести повідомлення про помилку.*/

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("\nВведите целое число от 1 до 100: ");
            string numberString = Console.ReadLine();
            int number = Int16.Parse(numberString);

            if (number < 1 || number > 100)
                Console.WriteLine($"\nОшибка!!! Число за пределами диапазона от 1 до 100 \n");
            else if (number % 3 == 0 & number % 5 == 0)
                Console.WriteLine("\n Fizz Buzz\n");
            else if (number % 3 == 0)
                Console.Write("\nFizz\n");
            else if (number % 5 == 0)
                Console.WriteLine("\nBuzz\n");
            else
                Console.Write($"\n Число: {number}\n");
        }
    }
}