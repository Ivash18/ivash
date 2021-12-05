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
            Console.WriteLine("Введите трехзначное число: ");
            int x = int.Parse(Console.ReadLine());
            if ((x > 999) || (x < 100))
                Console.WriteLine("Вы ввели не трехзначное число!");
            else
                Console.WriteLine(res(x.ToString()));
            Console.ReadLine();
        }
        static string res(string s)
        {
            char[] n = s.ToArray();
            n = n.Reverse().ToArray();
            string str = null;
            foreach (char ch in n)
                str = string.Concat(str, ch);
            return str;
        }
    }
}