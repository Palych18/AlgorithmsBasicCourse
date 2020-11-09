using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        //Павел Егоров
        //11. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее 
        //арифметическое всех положительных четных чисел, оканчивающихся на 8.

        static void Main(string[] args)
        {
            int n = 0;
            int i = 0;
            int num = 1;
           
            while (num != 0)
            {
                Console.Write("Введите число: ");
                num = Convert.ToInt32(Console.ReadLine());
                if(num > 0 && (num%10 == 8))
                {
                    n += num;
                    i++;
                }
                
            }

            if (i == 0) Console.WriteLine("Либо положительные числа отсутствуют, либо чисел оканчивающихся на 8 нет.");
            else
            {
                double sum = n / i;
                Console.WriteLine($"Среднее арифметическое введёных положительных чисел, оканчивающихся на 8 равно {sum:f2}");
            } 
                

            Console.ReadKey();
        }
    }
}
