﻿using System;

namespace ArrayApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstRandom = 1;
            int lastRandom = 10;
            int maxNumber = int.MinValue;
            int valueForReplace = 0;

            int[,] matrixA = new int[10, 10];

            Random random = new Random();

            Console.WriteLine("Исходная матрица: ");

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = random.Next(firstRandom, lastRandom);
                    maxNumber = matrixA[i, j] > maxNumber ? matrixA[i, j] : maxNumber;

                    Console.Write(matrixA[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nМаксимальное значение элемента в матрице: {maxNumber}\n");
            Console.WriteLine("Полученная матрица: ");

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = matrixA[i, j] == maxNumber ? valueForReplace : matrixA[i, j];

                    Console.Write(matrixA[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}