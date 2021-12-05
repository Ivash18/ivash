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

namespace program3._3
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
            double A, B, H;
            A = Convert.ToInt32(a.Text);
            B = Convert.ToInt32(b.Text);
            H = Convert.ToInt32(h.Text);
            f(A, B, H);
            for (double x = 0; x <= B; x += 1)
            {
                f(x, out double y);
                answer.Text = Convert.ToString($"f({x,5:F})={y,10:F2}");
            }
            Console.Read();
        }
        static void f(double a, double b, double h)
        {
            double f = 0;
            for (double x = a; x <= b; x += h)
            {
                if (Math.Abs(x) < 0)
                    f = 0;
                else if (Math.Abs(x) >= 0 & x != 1)
                    f = x * x + 1;
                else if (Math.Abs(x) == 1)
                    f = 1;
                answer.Text = Convert.ToString(("f({0,5:F})={1,10:F2}", x, f));
            }
        }
        static void f(double x, out double y)
        {
            double a = 10;
            y = x < 0
            ? 0
            : x >= 0 & x != 1
            ? x * x + 1
            : 1;
        }
    }
}
