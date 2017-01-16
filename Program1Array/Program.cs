﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1Array
{
    class Program
    {
        public static int Main(string[] args)
        {
            string[] firstNames = { "Саша", "Маша", "Олег", "Света", "Игорь" };
            Console.WriteLine("Here is the array:");
            for (int i = 0; i < firstNames.Length; i++)
                Console.WriteLine(firstNames[i] + "\t");
            Console.WriteLine("\n");
            Array.Reverse(firstNames);
            for (int i = 0; i < firstNames.Length; i++)
                Console.WriteLine(firstNames[i] + "\t");
            Console.WriteLine("\n");
            Console.WriteLine("Cleared out all but one…");
            Array.Clear(firstNames, 1, 4);
            for (int i = 0; i < firstNames.Length; i++)
                Console.WriteLine(firstNames[i] + "\t\n");
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
            return 0;
        }

    }
}
