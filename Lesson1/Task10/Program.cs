using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        //Павел Егоров
        //10. Дано целое число N(> 0). С помощью операций деления нацело и взятия остатка от деления
        //определить, имеются ли в записи числа N нечетные цифры.Если имеются, то вывести True, если 
        //нет — вывести False.

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int ost;
            int a = 0;
            
            while (n != 0)
            {
                ost = n % 10;
                if (ost % 2 != 0) a++;
                n /= 10;
            }
            if (a > 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadKey();
        }

    }
}
