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
        //1. Реализовать перевод из десятичной в двоичную систему счисления с использованием стека.

        public static int[] stack1 = new int[100];
        public static int n = -1;
        public static void Push(int a)
        {
            if (n < 100)
            {
                n++;
                stack1[n] = a;
            }
            else Console.WriteLine("Стэк переполнен.");
        }
        public static int Pop()
        {
            if (n != -1)
            {
                return stack1[n--];
            }
            else
            {
                Console.WriteLine("Стэк пустой.");
                return 0;
            }
        }
        public static void Numbers(int a)
        {
            int b;
            while (a != 0)
            {
                b = a % 2;
                Push(b);
                a = a / 2;
            }
        }
        static void Main(string[] args)
        {
            int q;
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Numbers(a);
            while (n != -1)
            {
                q = Pop();
                Console.Write(q);
            }
            Console.ReadKey();
        }
    }
}
