using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        //Павел Егоров
        //2. Найти максимальное из четырех чисел. Массивы не использовать.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четыре числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int max;

            if (a > b && a > c && a > d) max = a;
            else if (b > c && b > d) max = b;
            else if (c > d) max = c;
            else max = d;
            Console.WriteLine($"Максимальное число - {max}");
            Console.ReadKey();
        }
    }
}
