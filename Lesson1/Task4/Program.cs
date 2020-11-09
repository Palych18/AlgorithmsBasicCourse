using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        //Павел Егоров
        //4. Написать программу нахождения корней заданного квадратного уравнения.

        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение коэффициентов");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            //Находим дискриминант
            double d = Math.Pow(b, 2) - (4 * a * c);

            //Находим корни уравнения в зависимлсти от полученного дискриминанта
            if (a != 0)
            {
                if (d < 0) Console.WriteLine($"При отрицательном значении дискриминанта (D = {d}) корни уравнения отсутствуют!");
                else
                {
                    double x1 = -(b - Math.Sqrt(d)) / (2 * a);
                    double x2 = -(b + Math.Sqrt(d)) / (2 * a);
                    if (x1 == x2) Console.WriteLine($"При нулевом значении дискриминанта (D = 0) корень уравнения Х = {x1:f1}.");
                    else Console.WriteLine($"Корни квадратного уравнения равны Х1 = {x1:f1} и Х2 = {x2:f1}.");
                }
            }
            else Console.WriteLine("Коэффициент \"а\" не должен равняться нулю!");

            Console.ReadKey();
        }
    }
}
