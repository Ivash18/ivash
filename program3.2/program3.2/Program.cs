using System;
namespace Hello
{
    class Program
    {
        static double f(double x)
        {
            double y;
            if (x < 0) y = 0;
            else if (x >= 0 & x!= 1) y = x * x + 1;
            else y = 1;
            return y;
        }
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
        }
    }
}