using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        //Павел Егоров
        //1. Реализовать простейшую хеш-функцию. На вход функции подается строка, на выходе сумма кодов символов.

        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            String inputString = Console.ReadLine();
            int summ = 0;
            foreach (var item in inputString)
            {
                summ += (int)item;
            }
            Console.WriteLine($"Хеш строки [{inputString}] равен {summ}");
            Console.ReadKey();
        }
    }
}
