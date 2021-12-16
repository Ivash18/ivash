using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class xeks
    {
        public void m()
        {
            Console.WriteLine("введиет дату в формате дата.месяц.год(пример 30.01.2016)");
            string text = Convert.ToString(Console.ReadLine());

            string pattern = "[0-3][0-9].[0-1][0-9].[1,2][9,0][0-9][0-9]";

            MatchCollection matches;
            Regex reg = new Regex(pattern);
            matches = reg.Matches(text);

            {
                for (int i = 0; i < matches.Count; i++)
                {
                    string updDate = DateTime.Parse(matches[i].Value).AddDays(-1).ToShortDateString();
                    text = text.Replace(matches[i].Value, updDate);                 
                }
                Console.WriteLine("дата предыдущенго дня {0}", text);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            xeks f1 = new xeks();

            f1.m();
            Console.ReadLine();

        }
    }
}