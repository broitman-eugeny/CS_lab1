//Визуальное программирование. Лабораторная работа №1
//Вариант 2
//2.2. Найти суммы элементов двухмерного массива целых чисел,
//расположенных на линиях, параллельных главной диагонали, и ниже нее.
using System;
namespace lab1_2._2
{
    class Program
    {
        int SumInDiagUnderMainDiag(int[,] m, int nDiag)
        {
            if(nDiag>= m.GetLength(0))
            {
                Console.WriteLine("Неверно задан номер диагонали");
                return 0;
            }
            int sum=0;
            for (int i = 0, j = i + nDiag, maxI = m.GetLength(0) - nDiag; i < maxI; i++, j++)
            {
                sum += m[j,i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[,] m = new int[5, 5];
            Random rndm = new Random();
            for(int i=0; i<m.GetLength(0); i++)
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    m[i,j] = rndm.Next(100);
                }
            Console.WriteLine("Исхдный массив:");
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write("{0}\t", m[i, j]);
                }
                Console.WriteLine("\n");
            }
            Program p = new Program();
            for (int i = 1; i < m.GetLength(0); i++)
            {
                Console.WriteLine("Сумма элементов {0}-й диагонали: {1}", i, p.SumInDiagUnderMainDiag(m, i));
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
