/*Завдання 5
Користувач вводить з клавіатури дату. Додаток має
відобразити назву пори року і дня тижня. Наприклад,
якщо введено 22.12.2021, додаток має відобразити Winter
Wednesday.*/

using Microsoft.VisualBasic;
using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date_time;
            Console.Write(" Введите дату в формате dd.mm.yyyy: ");
            date_time = Console.ReadLine();
            DateTime datetime = DateTime.ParseExact(date_time, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            string seazon = "unknown";
            switch (datetime.Month)
            {
                case 12:
                case 1:
                case 2:
                    seazon = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    seazon = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    seazon = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    seazon = "Autumn";
                    break;
            }
            Console.WriteLine($"\nSeason: {seazon}\nDay of week: {datetime.DayOfWeek}");
        }
    }
}