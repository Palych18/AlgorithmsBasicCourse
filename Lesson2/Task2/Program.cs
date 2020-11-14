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
        //2. Реализовать функцию возведения числа a в степень b:
        
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double c = 1;

            if (b > 0)
            {
                for (int i = 1; i <= b; i++)
                {
                    c *= a;
                }
            }

            else if (b < 0)
            {
                for (int i = (-1); i >= b; i--)
                {
                    c *= a;
                }
                c = 1 / c;
            }
            
            Console.WriteLine($"Число {a} в степени {b} равно {c:f2}.");
            Console.ReadKey();
        }
    }
}
