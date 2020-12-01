using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        //Павел Егоров
        //1. Написать функции, которые считывают матрицу смежности из файла и выводят ее на экран.

        static void Load(string path, out int[,] a)
        {
            StreamReader sr = new StreamReader(path);
            int N = Convert.ToInt32(sr.ReadLine());
            a = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                string temp = sr.ReadLine();
                string[] mTemp = temp.Split(Convert.ToChar(" "));
                for (int j = 0; j < N; j++)
                {
                    a[i, j] = int.Parse(mTemp[j]);
                }
            }
        }

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] a;
            string path = "C:\\Users\\pavel\\Desktop\\C#\\AlgorithmsBasicCourse\\Task1.txt";
            Load(path, out a);
            Print(a);
            Console.ReadKey();
        }
    }
}
