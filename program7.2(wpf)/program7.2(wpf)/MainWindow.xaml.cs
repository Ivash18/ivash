using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace program7._2_wpf_
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            void Main(string[] args)
            {
                string s;
                s = Convert.ToString(ses.Text);
                char[] seps = { ' ', '.', ',', '!', '?', '-' };
                string[] parts = s.Split(seps);
                int min = 1000;
                int x = 0;
                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i].Length <= min)
                    {
                        min = parts[i].Length;
                        x = i;
                    }
                }
                answer.Text = Convert.ToString("Самое короткое слово: " + parts[x]);
            }
        }
    }
}
