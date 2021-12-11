using System;
using System.Linq;
using System.Text;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_number = Console.ReadLine();
            char[] char_arr = str_number.ToCharArray();
            Console.WriteLine("Количество цифр в строке: " + char_arr.Where((number) => number >= '0' && number <= '9').Count());
            Console.ReadKey();
        }
    }
}
