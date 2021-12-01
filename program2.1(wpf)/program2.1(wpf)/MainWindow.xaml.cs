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

namespace program2._1_wpf_
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double X, Y;
            X = Convert.ToInt32(x.Text);
            Y = Convert.ToInt32(y.Text);
            {
                var values = new List<double> {

                    -(X - 70),
                    X - Y,
                    Y
                };
                if (values.Any(v => v < 0)) 
                    Answer.Text = Convert.ToString("Нет");
                else
                    Answer.Text = Convert.ToString("Да");

            }
        }
    }
}
