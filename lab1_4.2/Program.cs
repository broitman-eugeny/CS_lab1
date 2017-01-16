//Визуальное программирование. Лабораторная работа №1
//Вариант 2
//4.2. Задан текст.Определить является ли он кодом HTML : содержит теги <html>, <form>, <h1>.
using System;
using System.Text.RegularExpressions;

namespace lab1_4._2
{
    class Program
    {
        bool isHTML(string str)
        {
            string tempS = "<html>|<form>|<h1>";
            Regex regex = new Regex(tempS, RegexOptions.IgnoreCase);
            Match match = regex.Match(str);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Анализируемый текст 1:");
            string str = "<hTml> Это пример HTML <Html>";
            Program p = new Program();
            Console.WriteLine("{0} - это {1}", str, p.isHTML(str)?"HTML":"Не HTML");
            Console.WriteLine("Анализируемый текст 2:");
            str = "Это пример НЕ HTML";
            Console.WriteLine("{0} - это {1}", str, p.isHTML(str) ? "HTML" : "Не HTML");
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
