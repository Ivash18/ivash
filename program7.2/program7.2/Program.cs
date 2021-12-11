using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string s;
            s = Console.ReadLine();
            char[] seps = { ' ', '.', ',', '!', '?', '-' };
            string[] parts = s.Split(seps);
            int min = 1000;
            int x = 0;
            for(int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length <= min)
                {
                    min = parts[i].Length;
                    x = i;
                }
            }
            Console.WriteLine("Самое короткое слово: " + parts[x]);

        }
    }
}