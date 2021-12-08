using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace azhigalieva
{
    class Program
    {
        static double B(int n)
        {
            if (n < 1) throw new ArgumentOutOfRangeException();
            return n == 1 ? 5 : B(n - 1) / ((n - 1) * (n - 1) + n);
        }

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; ++i)
            {
                Console.WriteLine("b{0,-2} = {1}", i, B(i));
            }
            Console.ReadLine();
        }
    }
}
