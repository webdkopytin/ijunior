﻿using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string userName = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш знак зодиака: ");
            string userZodiacSign = Console.ReadLine();
            Console.Write("Планируемый доход: ");
            int plannedIncome = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вас зовут {userName}, вам {userAge} год, вы {userZodiacSign} и ваш планируемый доход равен {plannedIncome}");
            Console.ReadKey();
        }
    }
}
