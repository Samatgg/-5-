using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков_5
{
    internal class Program
    {
        static void Max_chislo(int a, int b)
        {
            int maxch = Math.Max(a, b); // Для упр 5.1
            if (a != b)
            {
                Console.WriteLine($"Максимальное число - {maxch}");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }
        }
        static void Mesta(int first, int second) // Для упр 5.2
        {
            int save = first;
            first = second;
            second = save;
            Console.WriteLine($"После изменения: первое число - {first}, второе число - {second}");
        }
        static bool Factorial(int a) // Для упр 5.3 
        {
            int vmeste = 1;
            try
            {
                checked
                {
                    for (int i = 1; i <= a; i++)
                    {
                        vmeste *= i;
                    }
                    return true;
                }
            }
            catch (OverflowException)
            {
                return false;
            }
        }
        static void Factorial1(int a) // Для упражнения 5.4
        {
            int vmeste = 1;
            try
            {
                checked
                {
                    for (int i = 1; i <= a; i++)
                    {
                        vmeste *= i;
                    }
                    Console.WriteLine($"Факториалом числа {a} является {vmeste}");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка переполнения!");
            }
        }
        static void NOD(int a, int b) // Для дз 5.1
        {
            int maxch = 0;
            int min = Math.Min(a, b);
            if (a != 0 && b != 0)
            {
                for (int i = 1; i <= min; i++)
                {
                    if (a % i == 0 && b % i == 0 && i > maxch)
                    {
                        maxch = i;
                    }
                }
            }
            else
            {
                Console.WriteLine("Числа нельзя делить на ноль!");
            }
            Console.WriteLine($"НОД чисел {a} и {b} является - {maxch}");
        }
        static void NOD(int a, int b, int c) // Для дз 5.1
        {
            int min = Math.Min(b, c);
            int maxch = 0;
            if (a != 0 && b != 0 && c != 0)
            {
                for (int i = 1; i <= min; i++)
                {
                    if (a % i == 0 && c % i == 0 && b % i == 0 && i > maxch)
                    {
                        maxch = i;
                    }
                }
            }
            else
            {
                Console.WriteLine("Числа нельзя делить на ноль!");
            }
            Console.WriteLine($"НОД чисел {a},{b},{c} является - {maxch}");
        }
        static void Main(string[] args)
        {
            // Тумаков упр 5.1 - написать метод, возвращающий наибольшее из двух чисел
            Console.WriteLine("Тумаков упр 5.1 - написать метод, возвращающий наибольшее из двух чисел\n");
            Console.WriteLine("Введите первое число");
            int first, second;
            bool f = int.TryParse(Console.ReadLine(), out first);
            Console.WriteLine("Введите второе число");
            bool s = int.TryParse(Console.ReadLine(), out second);
            if (f && s)
            {
                Max_chislo(first, second);
            }
            else
            {
                Console.WriteLine("Числа введены некорректно");
            }
            // Тумаков упр 5.2 - поменять значения местами
            Console.WriteLine("\nТумаков упр 5.2 - поменять значения местами\n");
            int number1, number2;
            Console.WriteLine("Введите первое число");
            bool n1 = int.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Введите второе число");
            bool n2 = int.TryParse(Console.ReadLine(), out number2);
            if (n1 && n2)
            {
                Mesta(number1, number2);
            }
            else
            {
                Console.WriteLine("Числа введены некорректно");
            }
            // Тумаков упр 5.3 - метод вычисл. факториала числа с блоком cheked, возвращать true или false
            Console.WriteLine("\nТумаков упр 5.3 - метод вычисл. факториала числа с блоком cheked, возвращать true или false\n");
            Console.WriteLine("Введите число");
            int factor;
            bool fc = int.TryParse(Console.ReadLine(), out factor);
            if (fc)
            {
                if (factor >= 0)
                {
                    Console.WriteLine(Factorial(factor));
                }
                else
                {
                    Console.WriteLine("Факториал бывает только у натуральных чисел и у нуля");
                }
            }
            else
            {
                Console.WriteLine("Некорректно ввели число");
            }
            // Тумаков упр 5.4 - Написать рекурсивный метод вычисления факториала
            Console.WriteLine("\nТумаков упр 5.4 - Написать рекурсивный метод вычисления факториала\n");
            Console.WriteLine("Введите число");
            int factor1;
            bool fc1 = int.TryParse(Console.ReadLine(), out factor1);
            if (fc1)
            {
                if (factor >= 0)
                {
                    Factorial1(factor1);
                }
            }
            else
            {
                Console.WriteLine("Некорректно ввели число");
            }

            // Тумаков.ДЗ.Упр 5.1 - метод который находит НОД двух чисел, с таким же название НОД трех чисел
            Console.WriteLine("\nТумаков.ДЗ.Упр 5.1 - метод который находит НОД двух чисел, с таким же название НОД трех чисел\n");
            Console.WriteLine("Введите три числа");
            int Nfirst, Nsecond, Nthird;
            bool nf = int.TryParse(Console.ReadLine(), out Nfirst);
            bool ns = int.TryParse(Console.ReadLine(), out Nsecond);
            bool nt = int.TryParse(Console.ReadLine(), out Nthird);
            if (nf && ns && nt)
            {
                NOD(Nfirst, Nsecond);
                NOD(Nsecond, Nthird);
                NOD(Nfirst, Nsecond, Nthird);
            }
            else
            {
                Console.WriteLine("Некорректно ввели числа");
            }
            // Тумаков ДЗ Упр 5.2 - Рекурсивный метод вычисляющий значение n числа.Ряд Фибоначчи
            Console.WriteLine("Тумаков ДЗ Упр 5.2 - Рекурсивный метод вычисляющий значение n числа.Ряд Фибоначчи");
            Console.WriteLine("Введите номер ряда Фибоначчи");
            int num;
            bool nn = int.TryParse(Console.ReadLine(), out num);
            if (nn)
            {
                if (num >= 1)
                {

                }
            }
            else
            {
                Console.WriteLine("Некорректно ввели число");
            }
        }
    }
}
