using System;
using System.Text.RegularExpressions;
namespace Program7Regex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string si = "Это строка для поиска";
            // найти любой пробельный символ следующий за непробельным
            Regex theReg = new Regex(@"(\S+)\s");
            // получить коллекцию результата поиска
            MatchCollection theMatches = theReg.Matches(si);
            // перебор всей коллекции
            foreach (Match theMatch in theMatches)
            {
                Console.WriteLine("theMatch.Length: {0}",
                    theMatch.Length);
                if (theMatch.Length != 0)
                    Console.WriteLine("theMatch: {0}", theMatch.ToString());
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
