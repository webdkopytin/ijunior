﻿using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degreeNumber = 1;
            int countDegree = 0;
            int randomNumber;
            int minRandomNumber = 1;
            int maxRandomNumber = 400;
            int specifiedNumber = 2;

            bool isExit = false;

            Random random = new Random();
            randomNumber = random.Next(minRandomNumber, maxRandomNumber);

            Console.WriteLine($"Найдите минимальную степень {specifiedNumber}, превосходящую число {randomNumber}.");

            while (isExit == false)
            {
                if (degreeNumber <= randomNumber)
                {
                    degreeNumber *= specifiedNumber;
                    countDegree++;
                }
                else
                {
                    isExit = true;
                }
            }

            Console.WriteLine($"Ответ: {countDegree}");
            Console.ReadKey();
        }
    }
}
