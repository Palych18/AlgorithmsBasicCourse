using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        //Павел Егоров
        //3. **Исполнитель «Калькулятор» преобразует целое число, записанное на экране. 
        //У исполнителя две команды, каждой присвоен номер:
        //1. Прибавь 1.
        //2. Умножь на 2.

        static void Main(string[] args)
        {
            int Progr1(int s, int e, int p, int m)
            {
                if (e < s) return 0;
                if (e == s) return 1;
                return Progr1(s + p, e, p, m) + Progr1(s * m, e, p, m);
            }

            Console.WriteLine(Progr1(3, 20, 1, 2));
            Console.ReadKey();
        }
    }
}
