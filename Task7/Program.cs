//Завдання 7
//Користувач вводить з клавіатури два числа. Потрібно показати усі парні числа у вказаному діапазоні.
//Якщо межі діапазону вказані неправильно, потрібно провести
//нормалізацію кордонів. Наприклад, користувач ввів 20 і 11.
//Потрібна нормалізація, після якої початок діапазону
//дорівнюватиме 11, а кінець дорівнюватиме 20.

using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int max = num2, min = num1;
            if (num1 > num2) { max = num1; min = num2; }
            Console.WriteLine();
            for (int i = min; i < max; i++)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}