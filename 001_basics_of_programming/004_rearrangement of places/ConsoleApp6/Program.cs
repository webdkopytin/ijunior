﻿using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstVariable = 1;
            int secondVariable = 2;
            Console.WriteLine($"Значение первой переменной: {firstVariable}, второй переменной: {secondVariable}");
            int third = firstVariable;
            firstVariable = secondVariable;
            secondVariable = third;
            Console.WriteLine($"Значение первой переменной: {firstVariable}, второй переменной: {secondVariable}");
            Console.ReadKey();
        }
    }
}
