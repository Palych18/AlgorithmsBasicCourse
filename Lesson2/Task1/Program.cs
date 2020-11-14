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
        //1. Реализовать функцию перевода чисел из десятичной системы в двоичную, используя
        //рекурсию.


        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            List<int> number = new List<int>();

            while(num != 0)
            {
                i = num % 2;
                number.Add(i);
                num = num / 2;
            }

            number.Reverse();
            foreach(int item in number)
           
            Console.Write(item);
            Console.ReadKey();
        }
    }
}
