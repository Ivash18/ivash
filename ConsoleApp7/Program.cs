using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    private static void Main()
    {
        do
        {
            Console.Write("x = ");
            var x = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("y = ");
            var y = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"A({x}, {y}) => {ContainsPoint(x, y)}");
        } while (true);
        Console.ReadKey();
    }
    private static string ContainsPoint(double x, double y)
    {
        var values = new List<double> {
           -(x - 70),
           x - y,
           y
       };
        if (values.Any(v => v < 0))
            return "Нет";
        return values.Any(v => Math.Abs(v) < 0.01) ? "На границе" : "Да"; 

    }

}