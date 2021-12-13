using System;
using System.Linq;
using System.IO;

namespace thread2180303
{
    class Program
    {
        static void Main()
        {
            Random r = new Random();
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            var a = Enumerable.Range(0, n).Select(v => r.NextDouble() * (10 + 10) - 10);
            double average = a.Where((v, i) => i % 2 != 0).Average();
            File.WriteAllText("C:/Users/vanya/OneDrive/Рабочий стол/output.txt", String.Join(" ", a));
            Console.WriteLine($"Среднее арифметическое элементов на чётных позициях = {average}");
            Console.ReadKey();
        }
    }
}