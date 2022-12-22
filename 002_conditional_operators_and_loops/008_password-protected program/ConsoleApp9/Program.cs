﻿using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwordForPrivateMassage = "123456";
            string inputPassword;
            string privateMassage = "OK Message!";
            string wrongMassage = "Wrong!";

            int maximumPasswordRemaning = 3;
            int minimumPasswordRemaning = 0;

            bool isStatusExit = false;

            while (isStatusExit == false)
            {
                Console.Write("Введите пароль для просмотра сообщения: ");
                inputPassword = Console.ReadLine();

                if (inputPassword == passwordForPrivateMassage)
                {
                    Console.WriteLine(privateMassage);
                    isStatusExit = true;
                }
                else
                {
                    Console.WriteLine(wrongMassage);
                    --maximumPasswordRemaning;
                }

                if (maximumPasswordRemaning == minimumPasswordRemaning)
                {
                    Console.WriteLine("Кол-во попыток исчерпано.");
                    isStatusExit = true;
                }
            }
            Console.ReadLine();
        }
    }
}