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
        //1. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела по формуле I=m/(h* h); где
        //m-масса тела в килограммах, h - рост в метрах.
        static void Main(string[] args)
        {
            Console.Write("Введите вес человека в килограммах: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите рост человека в метрах: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double i = m / (h * h);
            Console.WriteLine($"Индекс массы Вашего тела равен {i:f2}");
            Console.ReadKey();
        }
    }
}
