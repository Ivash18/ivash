using System;

namespace program6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[][] ar = new int[n][];
            for (int i = 0; i < n; i++)
            {
                ar[i] = new int[n];
                for (int j = 0; j < n; j++)
                    ar[i][j] = rnd.Next(-100, 100);
            }

            foreach (int[] row in ar)
            {
                foreach (int element in row)
                {
                    Console.Write(element.ToString() + " ");
                }
                Console.WriteLine();
            }
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                num[i] = -1;
                for (int j = 0; j < n; j++)
                {
                    if (ar[i][j] < 0)
                    {
                        num[i] = j;
                        break;
                    }
                }
            }
            Console.Write("\n");
            for (int j = 0; j < n; j++)
                Console.Write(String.Format(" {0} ", num[j]));
            Console.Write("\n");
        }
    }
}
