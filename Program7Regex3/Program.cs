using System;
using System.Text.RegularExpressions;

namespace Program7Regex3
{
    class Program
    {
        static void Main()
        {
            string si = "Один, Два, Три, Строка для разбора";
            Regex theRegex = new Regex(" |, ");
            int id = 1;
            foreach (string substring in theRegex.Split(si))
                Console.WriteLine("{0}: {1}", id++, substring);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
