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
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите шаг h: ");
            double h = double.Parse(Console.ReadLine());
            f(a, b, h);
            for (double x = 0; x <= b; x += 1)
            {
                f(x, out double y);
                Console.WriteLine($"f({x,5:F})={y,10:F2}");
            }
            Console.Read();
        }
        static void f(double a, double b, double h)
        {
            double f = 0;
            for (double x = a; x <= b; x += h)
            {
                if (Math.Abs(x) <= 0.1)
                    f = x*x*x - 0.1;
                else if (Math.Abs(x) <= 0.2)
                    f = 0.2 * x - 0.2;
                else if (Math.Abs(x) > 0.2)
                    f = x * x * x + 0.1;
                Console.WriteLine("f({0,5:F})={1,10:F2}", x, f);
            }
        }
        static void f(double x, out double y)
        {
            double a = 10;
            y = x < 0
            ? 0
            : x >= 0 & x != 1
            ? x * x + 1
            : 1;
        }
    }
}