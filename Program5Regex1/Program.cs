using System;
using System.Text.RegularExpressions;

namespace Program5Regex1
{
    class Program
    {
        string FindMatch(string str, string strpat)
        {
            Regex pat = new Regex(strpat);
            Match match = pat.Match(str);
            string found = "";
            if (match.Success)
            {
                found = match.Value;
                Console.WriteLine("Строка ={0}\tОбразец={1}\tНайдено ={2}",
                    str,strpat,found);
            }
            return (found);
        }
        public void TestSinglePat()
        {
            string str, strpat, found;
            Console.WriteLine("Поиск по образцу");
            //образец задает подстроку, начинающуюся с символа a, 
            //далее идут буквы или цифры.
            str = "start"; strpat = @"a\w+";
            found = FindMatch(str, strpat); //art
            str = "fab77cd efg";
            found = FindMatch(str, strpat); //ab77cd
                                            //образец задает подстроку, начинающуюся с символа a,
                                            //заканчивающуюся f с возможными символами b и d в середине
            strpat = "a(b|d)*f"; str = "fabadddbdf";
            found = FindMatch(str, strpat); //adddbdf
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.TestSinglePat();
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
