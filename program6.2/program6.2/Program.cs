using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, coord_min = 0, min, coord_max = 0, tmp = 0;
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int[] mas = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                mas[i] = int.Parse(Console.ReadLine());
            }

            min = mas[0];
            for (int i = 0; i < n; i++)
                Console.Write(mas[i] + " ");
            for (int i = 0; i < n; i++)
                if (mas[i] > max) { max = mas[i]; coord_max = i; }
            for (int i = 0; i < n; i++)
                if (mas[i] < min) { min = mas[i]; coord_min = i; }

            tmp = mas[coord_min];
            mas[coord_min] = mas[coord_max];
            mas[coord_max] = tmp;
            Console.Write("\n");
            for (int i = 0; i < n; i++)
                Console.Write(mas[i] + " ");
            Console.ReadKey();

        }
    }
}