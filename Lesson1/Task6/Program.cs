using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        //Павел Егоров
        //6. Ввести возраст человека (от 1 до 150 лет) и вывести его вместе с последующим словом «год», «года» или «лет».

        static void Main(string[] args)
        {
            Console.Write("Введите возраст человека от 1 до 150 лет: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int i1 = age % 10;
            int i2 = age % 100;

            if (age > 0 && age < 151)
            {
                if (i1 > 1 && i1 < 5 && (i2 < 11 || i2 > 15)) Console.WriteLine($"Человеку {age} года.");
                else if (i1 == 1 && i2 != 11) Console.WriteLine($"Человеку {age} год.");
                else Console.WriteLine($"Человеку {age} лет.");
            }
            else Console.WriteLine("Вы ввели не корректный возрст");
            Console.ReadKey();
        }
    }
}
