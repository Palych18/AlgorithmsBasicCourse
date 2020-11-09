using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        //Павел Егоров
        //7. С клавиатуры вводятся числовые координаты двух полей шахматной доски(x1, y1, x2, y2). 
        //Требуется определить, относятся ли поля к одному цвету или нет.

        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первого поля шахматной доски:");
            Console.Write("X1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y1 = ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты второго поля шахматной доски:");
            Console.Write("X2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y2 = ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            if ((x1 + y1) % 2 == 0 && (x2 + y2) % 2 == 0) Console.WriteLine("Оба поля чёрные.");
            else if ((x1 + y1) % 2 != 0 && (x2 + y2) % 2 != 0) Console.WriteLine("Оба поля белые.");
            else if ((x1 + y1) % 2 == 0 && (x2 + y2) % 2 != 0) Console.WriteLine("Первое поле чёрное, второе белое.");
            else Console.WriteLine("Первое поле белое, второе чёрное");

            Console.ReadKey();
        }
    }
}
