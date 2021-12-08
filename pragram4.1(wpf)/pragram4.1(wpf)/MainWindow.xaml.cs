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

namespace pragram4._1_wpf_
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
            double B(int n)
            {
                if (n < 1) throw new ArgumentOutOfRangeException();
                return n == 1 ? 5 : B(n - 1) / ((n - 1) * (n - 1) + n);
            }
            int N;
            N = Convert.ToInt32(n.Text);
            for (int i = 1; i <= N; ++i)
            {
                answer.Text = Convert.ToString((i,"=", B(i)));
            }
           
        }
    }
}
