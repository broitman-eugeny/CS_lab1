using System;
using System.Text.RegularExpressions;
namespace Program8Regex5
{
    class Program
    {
        public static void Main()
        {
            string stringl = "04:03:27 127.0.0.0 GotDotNet.ru";
            Regex theReg = new Regex(@"(?<время>(\d|\:)+)\s" +
                @"(?<ip>(\d|\.)+)\s" + @"(?<url>\S+)");
            // группа time - одна и более цифр или двоеточий, за которыми следует пробельный символ
            // группа ip адрес - одна и более цифр или точек, за которыми следует пробельный символ
            // группа url - один и более непробельных символов
            MatchCollection theMatches = theReg.Matches(stringl);
            foreach (Match theMatch in theMatches)
            {
                if (theMatch.Length != 0)
                {
                    // выводим найденную подстроку
                    Console.WriteLine("\ntheMatch: {0}", theMatch.ToString());
                    // выводим группу "time"
                    Console.WriteLine("время: {0}", theMatch.Groups["время"]);
                    // выводим группу "ip"
                    Console.WriteLine("ip: {0}", theMatch.Groups["ip"]);
                    // выводим группу "url"
                    Console.WriteLine("url: {0}", theMatch.Groups["url"]);
                }
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }        
    }
}
