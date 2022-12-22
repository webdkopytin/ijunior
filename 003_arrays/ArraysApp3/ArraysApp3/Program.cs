﻿using System;

namespace ArraysApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int arraySize = 30;

            int minRandomNumber = 0;
            int maxRandomNumber = 10;

            int[] localMaximum = new int[arraySize];

            Random array = new Random();

            for (int i = 0; i < localMaximum.Length; i++)
            {
                localMaximum[i] = array.Next(minRandomNumber, maxRandomNumber);

                Console.Write(localMaximum[i] + " ");
            }

            Console.WriteLine("\n\nРезультат поиска локальных максимумов:\n");

            if (localMaximum[0] > localMaximum[1])
            {
                Console.Write($"{localMaximum[0]}\t");
            }

            for (int i = 1; i < arraySize - 1; ++i)
            {
                if (localMaximum[i - 1] < localMaximum[i] && localMaximum[i + 1] < localMaximum[i])
                {
                    Console.Write($"{localMaximum[i]}\t");
                }
            }

            if (localMaximum[localMaximum.Length - 1] > localMaximum[localMaximum.Length - 2])
            {
                Console.Write($"{localMaximum[localMaximum.Length - 1]}");
            }

            Console.ReadKey();
        }
    }
}