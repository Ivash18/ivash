using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Foo(n);
        Console.ReadKey();
    }
    static void Foo(int N, int symbols = 1)
    {
        for (int i = N; i > symbols; i--)
        {
            Console.Write('*');
        }
        Console.Write(' ');
        Console.WriteLine();
        if (N > 0)
            Foo(N - 1);
    }
}