using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace задания_1_4
{
    internal class Program
    {
        static void Mass(ref int[] a) // Для упр 1
        {
            int b = 0;
            int c = 3;
            int save = a[b];
            a[b] = a[c];
            a[c] = save;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        static void chisla(int a) // Для упр 3
        {
            switch (a)
            {
                case 0:
                    Console.WriteLine(" ##\n#  #\n#  #\n ##");
                    break;
                case 1:
                    Console.WriteLine("  #\n ##\n# #\n  #\n  #");
                    break;
                case 2:
                    Console.WriteLine(" ##\n#  #\n  #\n #\n####");
                    break;
                case 3:
                    Console.WriteLine(" ##\n#  #\n  #\n#  #\n ## ");
                    break;
                case 4:
                    Console.WriteLine("#  #\n#  #\n####\n   #\n   #");
                    break;
                case 5:
                    Console.WriteLine("####\n#\n###\n   #\n###");
                    break;
                case 6:
                    Console.WriteLine(" ## \n#  #\n#\n# #\n#  #\n ##");
                    break;
                case 7:
                    Console.WriteLine("####\n  #\n #\n#");
                    break;
                case 8:
                    Console.WriteLine(" ##\n#  #\n ##\n#  #\n ##");
                    break;
                case 9:
                    Console.WriteLine(" ##\n#  #\n ##\n   #\n#  #\n ##");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вы ввели число, которое не подходит к данному диапазону");
                    Thread.Sleep(3000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
        }
        static void Main(string[] args)
        {
            // Упр 1 - Массив, в котором 20 случ.чисел, 2 числа поменять местами
            Console.WriteLine("\nУпр 1 - Массив, в котором 20 случ.чисел, 2 числа поменять местами\n");
            int[] bb = new int[20] { 20, 21, 23, 34, 56, 4, 22, 3, 4, 5, 6, 43, 4, 23, 345, 65, 67, 876, 54, 43 };
            for (int i = 0; i < bb.Length; i++)
            {
                Console.Write(bb[i] + " ");
            }
            Console.WriteLine();
            Mass(ref bb);

            // Упр 3 - Ввести число от 0 до 9 и их рисунок,если ввести "закрыть" или "exit" консоль закроется
            Console.WriteLine("\n\nУпр 3 - Ввести число от 0 до 9 и их рисунок,если ввести 'закрыть' или 'exit' консоль закроется\n");
            Console.WriteLine("Введите число от 0 до 9, или можете выйти, введя 'exit' или 'закрыть'");
            string word_num = Console.ReadLine();
            if (word_num.ToLower() == "закрыть" || word_num.ToLower() == "exit")
            {
                Environment.Exit(0);
            }
            else
            {
                int chislo;
                bool a = int.TryParse(word_num, out chislo);
                if (a)
                {
                    chisla(chislo);
                }
            }
        }
    }
}
