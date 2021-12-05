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

namespace program3._2_wpf_
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
            double f(double x)
            {
                double A, B, H;
                A = Convert.ToInt32(a.Text);
                B = Convert.ToInt32(b.Text);
                H = Convert.ToInt32(h.Text);
                double y;
                if (x < 0) y = 0;
                else if (x >= 0 & x != 1) y = x * x + 1;
                else y = 1;
                return y;
                for (double i = A; i <= B; i += H)
                {
                    answer.Text = Convert.ToString(("f({0:f2})={1:f4}", i, f(i)));
                }
            }
            
        }
    }
}
