using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2Array
{
    class Program
    {
        public static void PrintAr(string name, Array A)
        {
            Console.WriteLine(name);
            switch (A.Rank)
            {
                case 1:
                    for (int i = 0; i < A.GetLength(0); i++)
                        Console.Write("\t" + name + "[{0}]={1}", i, A.GetValue(i));
                    Console.WriteLine();
                    break;
                case 2:
                    for (int i = 0; i < A.GetLength(0); i++)
                    {
                        for (int j = 0; j < A.GetLength(1); j++)
                            Console.Write("\t" + name + "[{0},{1}]={2}", i, j, A.GetValue(i, j));
                        Console.WriteLine();
                    }
                    break;
                default: break;
            }
        }
        static void Main(string[] args)
        {
            int[] IntOneMesArray = { 25, 48, 732, 456, 18, 0, 1 };
            string[,] StrTwoMesArray =
            {
                { "0","Jack"},
                { "1", "Jane" },
                { "2", "Daniel" }
            };
            PrintAr("IntOneMesArray", IntOneMesArray);
            PrintAr("StrTwoMesArray", StrTwoMesArray);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
