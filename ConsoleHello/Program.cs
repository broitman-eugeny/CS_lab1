using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHello
{	// создаваемое пространство имен
    class Program
    {		// имя класса по умолчанию
        static void Main(string[] args)
        {
            // вывод строки на экран
            Console.WriteLine("Введите Ваше имя");
            string name;
            name = Console.ReadLine();	// ввод строки с клавиатуры
            if (name == "") Console.WriteLine("Здравствуй, мир!");
            else Console.WriteLine("Здравствуй, " + name + "!");
        }
    }
}
