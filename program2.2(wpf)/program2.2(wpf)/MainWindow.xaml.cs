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

namespace program2._2_wpf_
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string N;
            N = Convert.ToString(day.Text);
            switch (N)
            {
                case "понедельник": time.Text=Convert.ToString("10.00-13.00"); break;
                case "вторник": time.Text = Convert.ToString("8.00-15.00"); break;
                case "среда": time.Text = Convert.ToString("9.00-12.00"); break;
                case "четверг": time.Text = Convert.ToString("15.00-18.00"); break;
                case "пятница": time.Text = Convert.ToString("8.00-15.00"); break;
                case "суббота": time.Text = Convert.ToString("выходной"); break;
                case "воскресенье": time.Text = Convert.ToString("выходной"); break;
                default: time.Text = Convert.ToString("ВЫ ОШИБЛИСЬ"); break;
            }
        }
    }
}
