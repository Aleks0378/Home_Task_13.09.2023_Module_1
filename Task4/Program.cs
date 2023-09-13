using System;
/*
  Завдання 4
Користувач вводить шестизначне число.
Потім, користувач вводить номери розрядів для заміни цифр.
Наприклад, якщо користувач ввів 1 і 6 — це означає, що
треба поміняти місцями першу та шосту цифри.
Число 723895 має перетворитися на 523897.
Якщо користувач ввів не шестизначне число, потрібно
вивести повідомлення про помилку.
*/

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Введите шестизначное число: ");
            string str = Console.ReadLine();
            if (str.Length != 6)
                Console.WriteLine("\n Ошибка! Число не шестизначное.\n");
            else
            {
                Console.WriteLine($"\n Число до обмена цифр: {str}\n");
                Console.Write("\n Введите номер разряда для обмена цифр: ");
                string str1 = Console.ReadLine();
                int num1 = Int32.Parse(str1) - 1;
                Console.Write("\n Введите следующий номер разряда для обмена цифр: ");
                str1 = Console.ReadLine();
                int num2 = Int32.Parse(str1) - 1;
                Console.WriteLine($"\n Число разряда {num1 + 1} обменивается с разрядом {num2 + 1}\n");
                char[] numarr = new char[str.Length];
                for (int i = 0; i < str.Length; i++)
                    numarr[i] = str[i];
                char temp = numarr[num1];
                numarr[num1] = numarr[num2];
                numarr[num2] = temp;
                PrintArr("\n Число после обмена цифр: ", numarr);
            }


        }
        static void PrintArr(string text, char[] arr)
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i]);
            Console.WriteLine();
        }
    }
}