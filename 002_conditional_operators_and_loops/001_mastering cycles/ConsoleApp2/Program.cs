﻿using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько раз поздароваться? Введите число: ");
            int countSayHello = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Робот скажет \"Привет\" " + countSayHello + " раз.");

            for (int i = 1; i <= countSayHello; i++)
            {
                Console.WriteLine($"{i}) Привет!");
            }

            Console.ReadKey();
        }
    }
}
