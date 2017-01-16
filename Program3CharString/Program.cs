using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3CharString
{
    class Program
    {
        string CharArrayToString(char[] ar)
        {
            string result = "";
            for (int i = 0; i < ar.Length; i++) result += ar[i];
            return (result);
        }
        void PrintCharAr(string name, char[] ar)
        {
            Console.WriteLine(name);
            for (int i = 0; i < ar.Length; i++) Console.Write(ar[i]);
            Console.WriteLine();
        }
        public void TestCharArAndString()
        {
            string hello = "Здравствуй, Мир!";
            char[] strM1 = hello.ToCharArray();
            PrintCharAr("strM1", strM1);
            char[] World = new char[3];
            Array.Copy(strM1, 12, World, 0, 3); //копирование подстроки
            PrintCharAr("World", World);
            Console.WriteLine(CharArrayToString(World));
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            P.TestCharArAndString();
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
