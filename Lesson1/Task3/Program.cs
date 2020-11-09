using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        //Павел Егоров
        //3. Написать программу обмена значениями двух целочисленных переменных.
        
        static void Main(string[] args)
        {
            int a = 4;
            int b = 7;

            //С использованием третьей переменной.
            Console.WriteLine($"Начальные значения переменных а = {a}, b = {b}.");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"После обмена значений переменных а = {a}, b = {b}.");

            //Без использования третьей переменной.
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"После обратного обмена значений переменных а = {a}, b = {b}.");
            Console.ReadKey();
        }
    }
}
