using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        //Павел Егоров
        //8. Ввести a и b и вывести квадраты и кубы чисел от a до b.

        static void Main(string[] args)
        {
            Console.Write("Введите число \"a\" - ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число \"b\" - ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Квадраты чисел между а = {a} и b = {b}:");
            for (int i = a; i <= b; i++)
            {
                double square = Math.Pow(i, 2);
                Console.Write($"{square} ");
            }

            Console.WriteLine($"\nКубы чисел между а = {a} и b = {b}:");
            for (int i = a; i <= b; i++)
            {
                double cube = Math.Pow(i, 3);
                Console.Write($"{cube} ");
            }

            Console.ReadKey();

        }
    }
}
