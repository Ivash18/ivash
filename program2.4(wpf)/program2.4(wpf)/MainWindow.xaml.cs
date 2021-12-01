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

namespace program2._4_wpf_
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
            for (int i = 0; i <= 4; ++i)
            {

                answer.Text = Convert.ToString(" " + i);
            }
            for (int i = 0; i <= 3; ++i)
            {
                answer.Text = Convert.ToString(" " + i);
            }
            for (int i = 0; i <= 2; ++i)
            {
                answer.Text = Convert.ToString(" " + i);
            }
            for (int i = 0; i <= 1; ++i)
            {
                answer.Text = Convert.ToString(" " + i);
            }
            Console.WriteLine();
            for (int i = 0; i <= 0; ++i)
            {
                answer.Text = Convert.ToString(" " + i);
            }
        }
    }
}