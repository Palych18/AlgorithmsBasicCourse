using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        //Павел Егоров
        //9. Даны целые положительные числа N и K.Используя только операции сложения и вычитания, 
        //найти частное от деления нацело N на K, а также остаток от этого деления.

        static void Main(string[] args)
        {
            int n = 102;
            int k = 100;
            int ch = 0;
            int ost = n;

            if (n >= k)
            {
                while (ost >= k)
                {
                    ost -= k;
                    ch++;
                }
                Console.WriteLine($"Частное от деления числа N = {n} на число K = {k} будет равно {ch}");
                Console.WriteLine($"Остаток от деления числа N = {n} на число K = {k} будет равно {ost}");
            }
            else
            {
                Console.WriteLine($"Частное от деления числа N = {n} на число K = {k} будет равно {ch}");
                Console.WriteLine($"Остаток от деления числа N = {n} на число K = {k} будет равно {ost}");
            }

            Console.ReadKey();
        }
    }
}
