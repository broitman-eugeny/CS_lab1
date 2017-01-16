//Визуальное программирование. Лабораторная работа №1
//Вариант 2
//3.2. Составить программу, которая будет вводить строку в переменную String.
//Подсчитать, сколько различных символов встречаются в ней. Вывести их на экран.
using System;
using System.Text.RegularExpressions;
using System.Text;
namespace lab1_3._2
{
    class Program
    {
        int difSymInStr(ref StringBuilder str)
        {
            string tempS=new string(("[^]".ToCharArray()));
            Regex regex = new Regex(".");
            Match match = regex.Match(str.ToString());
            while(match.Length > 0)
            {
                tempS = tempS.Insert(tempS.Length - 1, match.Value[0].ToString());
                regex = new Regex(tempS);
                match = regex.Match(str.ToString());
            }
            str = new StringBuilder(tempS.Substring(2, tempS.Length-3));
            return tempS.Length-3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            StringBuilder str = new StringBuilder(Console.ReadLine());
            Program p = new Program();
            Console.WriteLine("Количество различных символов в строке: {0} - {1}", p.difSymInStr(ref str), str);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
