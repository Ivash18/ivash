using System;
namespace cirandnum
{
    class Program
    {
        static void Main()
        {
            //1.1 задание
            Console.Write("Введите длину окружности l= ");
            float l = float.Parse(Console.ReadLine());
            double r = l/(2*3.14);
            Console.WriteLine("Получаем r= " + r);
            //1.2 задание
            char[] chNum;
            string num;
            Console.Write("Введите трехзначное число: ");
            num = Console.ReadLine();
            chNum = new char[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                chNum[i] = num[i];
            }
            if (Convert.ToInt32(chNum[0]) > Convert.ToInt32(chNum[chNum.Length - 1]))
                 Console.WriteLine("Первая цифра больше.");
            else if (Convert.ToInt32(chNum[0]) < Convert.ToInt32(chNum[chNum.Length - 1]))
                Console.WriteLine("Последняя цифра больше.");
            else
                Console.WriteLine("Первая и последняя цифры одинаковы.");
            Console.ReadKey();
        }
    }

}



