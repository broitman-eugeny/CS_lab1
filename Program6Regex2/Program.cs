using System;
using System.Text.RegularExpressions;

namespace Program6Regex2
{
    class Program
    {
        void FindMatches(string str, string strpat)
        {
            Regex pat = new Regex(strpat);
            MatchCollection match = pat.Matches(str);
            Console.WriteLine("Строка ={0}\tОбразец={1}\tНайдено ={2}",
                str,strpat,match.Count);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("око и рококо");
            string str, strpat;
            strpat = "око"; str = "рококо";
            Program p = new Program();
            p.FindMatches(str, strpat);	//найдено 1 соответствие
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
