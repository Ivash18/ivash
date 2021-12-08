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

namespace program4._2_wpf_
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
            void Main()
            {

                int N;
                N = Convert.ToInt32(n.Text);
                Foo(N);
            }
            void Foo(int N1, int symbols = 1)
            {
                for (int i = N1; i > symbols; i--)
                {
                    answer.Text = Convert.ToString('*');
                }
                answer.Text = Convert.ToString(' ');
                
                if (N1 > 0)
                    Foo(N1 - 1);
            }
        }
    }
}
