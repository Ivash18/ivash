using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
namespace MyProgram
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите заданную букву: ");
            int a = int.Parse(Console.ReadLine());
            StreamReader fileIn = new StreamReader("C:/Users/vanya/OneDrive/Рабочий стол/out.txt");
            string text = fileIn.ReadToEnd(); 

            
            
            string[] newText = Regex.Split(text, "[ ,.:;]+");
           
            for (int i = 0; i < newText.Length; i++)
            {
                if(newText.Length < a) Console.WriteLine(newText[i]);
            }
        }
    }
}