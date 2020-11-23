using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        //Павел Егоров
        //2. Написать программу, которая определяет, является ли введенная скобочная
        //последовательность правильной.

        public static char[] open = new char[] { '(', '[', '{' };
        public static char[] close = new char[] { ')', ']', '}' };

        static void Main(string[] args)
        {
            Console.Write("Введите выражение со скобками: ");
            string input = Console.ReadLine();
            CheckSequence(input);

            Console.ReadKey();
        }

        public static bool IsOpening(char c)
        {
            for (int i = 0; i < open.Length; i++)
            {
                if (c == open[i]) return true;
            }
            return false;
        }
        
        public static bool IsClosing(char c)
        {
            for (int i = 0; i < close.Length; i++)
            {
                if (c == close[i]) return true;
            }
            return false;
        }
        
        public static char GetOpening(char c)
        {
            for (int i = 0; i < close.Length; i++)
            {
                if (c == close[i]) return open[i];
            }
            return '0';
        }

        
        public static void CheckSequence(string sequence)
        {
            Stack stack = new Stack();
            stack.Init(10);
            string res = "Последовательность верна.";
            for (int i = 0; i < sequence.Length; i++)
            {
                if (IsOpening(sequence[i]))
                {
                    stack.Push(sequence[i]);
                }

                else if (IsClosing(sequence[i]))
                {
                    if (stack.Pop() != GetOpening(sequence[i]))
                    {
                        res = "Последовательноcть неверна.";
                        break;
                    }
                }
                else continue;
            }
            Console.WriteLine(res);
        }

        public static void PrintCursor(int pos)
        {
            for (int i = 0; i <= pos; i++)
            {
                if (i == pos) Console.WriteLine('^');
                else Console.Write(' ');
            }
        }

       
        public struct Stack
        {
            char[] array;

            int N;
            int maxN;

            public void Init(int maxN)
            {
                this.maxN = maxN;
                array = new char[maxN];
                N = -1;
            }

            public void Push(char el)
            {
                if (N < maxN)
                {
                    N++;
                    array[N] = el;
                }
                else
                {
                    Console.WriteLine("Stack overflow");
                }
            }

            public char Pop()
            {
                if (N != -1)
                {
                    return array[N--];
                }
                else
                {
                    Console.WriteLine("Stack empty");
                    return '#';
                }
            }

            public void Print()
            {
                if (N > 0)
                {
                    for (int i = N; N >= 0; N--)
                    {
                        Console.WriteLine(array[N]);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
