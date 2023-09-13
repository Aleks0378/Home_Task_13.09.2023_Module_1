using System;
/*
  Завдання 2
Користувач вводить з клавіатури два числа.
Перше число — це значення, друге число — відсоток, який необхідно підрахувати.
Наприклад, ми ввели з клавіатури 90 і 10. Потрібно вивести на екран 10 відсотків від 90.
Результат: 9.
*/


namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nВведите число: ");
            string numberString = Console.ReadLine();
            int number1 = Int16.Parse(numberString);
            Console.WriteLine($" Число: {number1}");
            Console.Write("\nВведите второе число-процент: ");
            numberString = Console.ReadLine();
            int number2 = Int16.Parse(numberString);
            Console.WriteLine($" Второе число: {number2} %");
            Console.WriteLine($"\n Результат: {number2}% от {number1} = {(number1 * number2) / 100}");
        }
    }
}
