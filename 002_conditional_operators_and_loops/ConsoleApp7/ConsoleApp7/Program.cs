﻿using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSetName = "set name";
            const string CommandChangeFontColor = "change color";
            const string CommandSetPassword = "set password";
            const string CommandWriteName = "write name";
            const string CommandShowAll = "show all";
            const string CommandEsc = "quit";
            const string ColorWhite = "white";
            const string ColorRed = "red";
            const string ColorMagenta = "magenta";
            const string ColorBlue = "blue";

            string name = "Noname";
            string consoleColor = "Black";
            string password = "1a2b3c";

            bool isExitStatus = false;

            Console.WriteLine("Поддерживаемые команды:\n" +
            $"{CommandSetName} – установить имя;\n" +
            $"{CommandChangeFontColor} - изменить цвет фона консоли;\n" +
            $"{CommandSetPassword} – установить пароль;\n" +
            $"{CommandWriteName} – вывести имя(после ввода пароля);\n" +
            $"{CommandShowAll} - показать все параметры\n" +
            $"{CommandEsc} – выход из программы.\n");

            while (isExitStatus == false)
            {
                Console.Write("Введите команду: ");
                string currentCommand = Console.ReadLine();

                switch (currentCommand)
                {
                    case CommandSetName:
                        Console.Write("Введите новое имя: ");
                        name = Console.ReadLine();

                        Console.WriteLine("Смена имени прошла успешно.");
                        break;

                    case CommandChangeFontColor:
                        Console.Write($"Возможные значения: {ColorWhite}, {ColorRed}, {ColorMagenta}, {ColorBlue}." +
                            $"Введите новый цвет консоли: ");
                        consoleColor = Console.ReadLine();

                        if (consoleColor == ColorWhite)
                            Console.ForegroundColor = ConsoleColor.White;
                        else if (consoleColor == ColorRed)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else if (consoleColor == ColorMagenta)
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        else if (consoleColor == ColorBlue)
                            Console.ForegroundColor = ConsoleColor.Blue;
                        break;

                    case CommandSetPassword:
                        Console.Write("Введите новое имя: ");
                        password = Console.ReadLine();

                        Console.WriteLine("Смена пароля прошла успешно.");
                        break;

                    case CommandWriteName:
                        Console.WriteLine("Для отображения текущего имени введите пароль: ");
                        string checkPassword = Console.ReadLine();

                        if (checkPassword == password)
                            Console.WriteLine("Проверка пройдена успешно! Текущее имя: " + name);
                        else
                            Console.WriteLine("Пароль не подходит. Прощайте!");

                        break;

                    case CommandShowAll:
                        Console.WriteLine("\n-------------------\nИмя: " + name);
                        Console.WriteLine("Цвет шрифта: " + consoleColor);
                        Console.WriteLine("Пароль: " + password + "\n-------------------\n");
                        break;

                    case CommandEsc:
                        isExitStatus = true;
                        break;
                }
            }
        }
    }
}