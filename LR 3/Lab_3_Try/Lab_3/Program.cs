using System;
using System.Collections.Generic;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, max, min, p, maxi = 0, maxj = 0, mini = 0, minj = 0;
            Console.Write("Поменять местами максимум и минимум в матрице!\n\n");
            Console.Write("Ввод размерности матрицы Mas[m,n]:\n\n");
            Console.Write("Введи m -> ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведи n -> ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] Mas = new int[m, n];
            Console.WriteLine("\nВвод матрицы: ");
            
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\nВведи Mas[{0},{1}]: ", i, j);
                    Mas[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                }
            Console.WriteLine("\nИсходная матрица: ");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", Mas[i, j]);
                }
            }
            for (int i = 0; i < m; i++)
            {
                min = int.MaxValue; max = int.MinValue;
                for (int j = 0; j < n; j++)
                {
                    if (Mas[i, j] > max)
                    {
                        max = Mas[i, j];
                        maxi = i;
                        maxj = j;
                    }
                    if (Mas[i, j] < min)
                    {
                        min = Mas[i, j];
                        mini = i;
                        minj = j;
                    }
                }
                p = Mas[maxi, maxj]; //меняем местами максимум с минимумом
                Mas[maxi, maxj] = Mas[mini, minj];
                Mas[mini, minj] = p;
            }
            min = int.MaxValue; max = int.MinValue;
            Console.WriteLine("\n\nОбработанная матрица: ");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", Mas[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}