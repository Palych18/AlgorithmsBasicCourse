using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        //Павел Егоров
        //12. Написать функцию нахождения максимального из трех чисел.


        static void Main(string[] args)
        {
            int MaxNum(int a, int b, int c)
            {
                int max;
                if (a > b && a > c) max = a;
                else if (b > c) max = b;
                else max = c;
                return max;
            }

            Console.WriteLine("Введите 3 числа: ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            int i2 = Convert.ToInt32(Console.ReadLine());
            int i3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Максимальное число: {MaxNum(i1, i2, i3)}");
            Console.ReadKey();
        }
    }
}
