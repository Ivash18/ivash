using System;
 
namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите размер массива:");

            int n = int.Parse(Console.ReadLine());
 
            Random random = new Random();
            
            int[] arr = new int[n];
 
            Console.WriteLine("Одномерный массив");
 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(5,20);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int ch = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Индексы одномерного массива больших числа {0}", ch);
 
            for (int i = 0; i < arr.Length; i++)
            {
               if (arr[i] > ch)
               {
                    Console.Write(i + " ");
               }
            }
 
            Console.WriteLine();
            Console.WriteLine("Двумерный массив");
            Console.Write("Укажите размер массива 1:");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Укажите размер массива 2:");
            int m = int.Parse(Console.ReadLine());
            int[,] multyArr = new int[n1, m];
 
            for (int i = 0; i < multyArr.GetLength(0); i++)
            {
                for (int j = 0; j < multyArr.GetLength(1); j++)
                {
                    multyArr[i,j] = random.Next(5, 20);
                    Console.Write(multyArr[i,j] + " ");
                }
                Console.WriteLine();
            }
            int ch1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Индексы двумерного массива больших числа {0}", ch1);
 
            for (int i = 0; i < multyArr.GetLength(0); i++)
            {
                for (int j = 0; j < multyArr.GetLength(1); j++)
                {
                    if (multyArr[i, j] > ch1)
                    {
                        Console.WriteLine("{0} {1} " ,i, j);
                    }                    
                }
            }
        }
    }
}