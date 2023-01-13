﻿using System;
using System.Collections.Generic;

namespace _001_ExplanatoryDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            Dictionary<string, string> dictionary;

            dictionary = new Dictionary<string, string>()
            {
                ["Абьюзер"] = "человек, который пользуется другими в отношениях, унижая и принуждая их делать что-то вопреки их желаниям",
                ["Агриться"] = "испытывать чувство злобы к определенной ситуации",
                ["Байтить"] = "полностью скопированный стиль, поступок или фраза",
                ["Буллинг"] = "травля и осуждение человека по любому поводу",
                ["Вайб"] = "атмосфера, возникающая при каких-либо обстоятельствах",
                ["Душнила"] = "скучный и нудный человек в компании, постоянно высказывающий непопулярное мнение, расхожее с остальными членами этой компании",
                ["Зашквар"] = "определение неактуальной или немодной ситуации/одежды/фразы/песни",
                ["Менспрейдинг"] = "термин, означающий мужскую привычку ездить в общественном транспорте с широко раздвинутыми ногами"
            };

            while (isOpen)
            {
                Console.Write("Введите слово для расшифровки его значения: ");
                string word = Console.ReadLine();

                if (dictionary.ContainsKey(word))
                    Console.WriteLine($"{word} - {dictionary[word]}\n");
                else
                    Console.WriteLine("Такого слова нет в нашем словаре.");
            }
        }
    }
}
