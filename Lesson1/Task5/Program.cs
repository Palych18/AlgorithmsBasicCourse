using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        //Павел Егоров
        //5. С клавиатуры вводится номер месяца. Требуется определить, к какому времени года он относится.

        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            if (m == 1 || m == 2 || m == 12) Console.WriteLine("Месяц относится к зиме.");
            else if (m == 3 || m == 4 || m == 5) Console.WriteLine("Месяц относится к весне.");
            else if (m == 6 || m == 7 || m == 8) Console.WriteLine("Месяц относится к лету.");
            else if (m == 9 || m == 10 || m == 11) Console.WriteLine("Месяц относится к осени.");
            else Console.WriteLine("Вы ввели неправильный номер месяца.");

            Console.ReadKey();
        }
    }
}
