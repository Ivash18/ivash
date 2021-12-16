using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace program8_wpf_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            void m()
            {
                Console.WriteLine("введиет дату в формате дата.месяц.год(пример 30.01.2016)");
                string text = Convert.ToString(date.Text);


                string pattern = "[0-3][0-9].[0-1][0-9].[1,2][9,0][0-9][0-9]";

                MatchCollection matches;
                Regex reg = new Regex(pattern);
                matches = reg.Matches(text);

                {
                    for (int i = 0; i < matches.Count; i++)
                    {
                        string updDate = DateTime.Parse(matches[i].Value).AddDays(-1).ToShortDateString();

                        answer.Text = Convert.ToString(text);
                    }
                }
            }
        }
    }
}