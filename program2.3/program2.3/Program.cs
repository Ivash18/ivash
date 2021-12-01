using System;
namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапазод от A до B(целые числа)");
            int A = int.Parse(Console.ReadLine());
            
            int B = int.Parse(Console.ReadLine());
            int k = A;
            while (k != B + 1)
            {
                if (k >= 0)
                    Console.Write(k + " ");
                k++;
            }
            k = A;
            Console.WriteLine();
            do
            {
                if (k >= 0)
                    Console.Write(k + " ");
                k++;
            }
            while (k != B + 1);
            Console.WriteLine();
            for (int i = A; i <= B; i++)
            {
                if (i >= 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}