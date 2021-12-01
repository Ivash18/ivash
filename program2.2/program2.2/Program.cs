using System;
namespace Hello
{
    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();
            switch (n)
            {
                case "понедельник": Console.WriteLine("10.00-13.00"); break;
                case "вторник":Console.WriteLine("8.00-15.00"); break;
                case "среда": Console.WriteLine("9.00-12.00"); break;
                case "четверг": Console.WriteLine("15.00-18.00"); break;
                case "пятница": Console.WriteLine("8.00-15.00"); break;
                case "суббота": Console.WriteLine("выходной"); break;
                case "воскресенье": Console.WriteLine("выходной"); break;
                default: Console.WriteLine("ВЫ ОШИБЛИСЬ"); break;
            }
        }
    }
}
