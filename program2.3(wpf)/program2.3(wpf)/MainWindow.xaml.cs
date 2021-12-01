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

namespace program2._3_wpf_
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
            int a, b;
            a = Convert.ToInt32(A.Text);
            b = Convert.ToInt32(B.Text);
            int k = a;
            k = Convert.ToInt32(A.Text);
            while (k != b + 1)
            {
                if (k >= 0)
                    answer.Text = Convert.ToString(k + " ");
                k++;
            }
            k = a;
            answer.Text = Convert.ToString(a);
            do
            {
                if (k >= 0)
                    answer.Text = Convert.ToString(k + " ");
                k++;
            }
            while (k != b + 1);
            answer.Text = Convert.ToString(a);
            for (int i = a; i <= b; i++)
            {
                if (i >= 0)
                    answer.Text = Convert.ToString(i + " ");
            }
            answer.Text = Convert.ToString(a);
        }
    }
}
