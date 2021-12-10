using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Class
    {
        static int[,] Input(out int n)
        {
            Console.WriteLine("введите размерность массива");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }

        static double norm(int[,] a)
        {
            double s = 0, s1 = 0;
            for (int i = 0; i < a.GetLength(0); ++i, s1 = 0)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    s1 = s1 + a[i, j];
                }
                if (s1 > s) s = s1;

            }
            Console.WriteLine("нормa матрицы = " + s);
            return s;
        }

        static void Main()
        {
            int n;
            int[,] myArray = Input(out n);
            Console.WriteLine("Исходный массив:");
            Print(myArray);
            norm(myArray);
            Console.ReadKey();

        }
    }
}