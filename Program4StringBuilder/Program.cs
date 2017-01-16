using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4StringBuilder
{
    class Program
    {
        public void TestStringBuilder()
        {
            StringBuilder s1 = new StringBuilder("ABC"),
                s2 = new StringBuilder("CDE"), s3 = new StringBuilder();
            s3 = s1.Append(s2);
            bool b1 = (s1 == s3);
            char ch1 = s1[0], ch2 = s2[0];
            Console.WriteLine("s1={0}, s2={1}, b1={2}," + "ch1={3}, ch2 ={4}",
                s1,s2,b1,ch1,ch2);
            StringBuilder s = new StringBuilder("Zenon");
            s[0] = 'L';
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.TestStringBuilder();
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
