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
        //1. Реализовать сортировку подсчетом.

        static void Main(string[] args)
        {
            const int m = 1000;
            int[] c = new int[m];
            int[] a = new int[] { 6, 3, 2, 5, 7, 5, 2, 3, 1, 4, 6, 8, 4, 78, 32, 12, 54, 67, 34, 62, 87, 98, 23, 76 };
            int b = 0;
            Console.Write("Массив до сортировки: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0,4}", a[i]);
            }
            for (int i = 0; i < m; i++)                         
            {                                                   
                c[i] = 0;
            }
            for (int i = 0; i < a.Length; i++)                  
            {                                                  
                c[a[i]]++;
            }
            for (int j = 0; j < m; j++)                         
            {
                for (int i = 0; i <= c[j] - 1; i++)            
                {                                               
                    a[b++] = j;
                }
            }
            Console.WriteLine();
            Console.Write("Массив после сортировки: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0,4}", a[i]);
            }
            Console.ReadKey();
        }
    }
}
