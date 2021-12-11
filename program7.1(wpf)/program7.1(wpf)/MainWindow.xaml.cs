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

namespace program7._1_wpf_
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
                string str_number = Console.ReadLine();
                char[] char_arr = str_number.ToCharArray();
                answer.Text = Convert.ToString("Количество цифр в строке: " + char_arr.Where((number) => number >= '0' && number <= '9').Count());
                Console.ReadKey();
            }
        }
    }
}
