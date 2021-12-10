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

namespace program6._4_wpf_
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
                
                int A = Convert.ToInt32(a.Text);
                Random rnd = new Random();
                int[][] ar = new int[A][];
                for (int i = 0; i < A; i++)
                {
                    ar[i] = new int[A];
                    for (int j = 0; j < A; j++)
                        ar[i][j] = rnd.Next(-100, 100);
                }

                foreach (int[] row in ar)
                {
                    foreach (int element in row)
                    {
                       answer.Text = Convert.ToString(element.ToString() + " ");
                    }
                }
                int[] num = new int[A];
                for (int i = 0; i < A; i++)
                {
                    num[i] = -1;
                    for (int j = 0; j < A; j++)
                    {
                        if (ar[i][j] < 0)
                        {
                            num[i] = j;
                            break;
                        }
                    }
                }
                for (int j = 0; j < A; j++)
                    answer.Text = Convert.ToString(String.Format(" {0} ", num[j]));
            }
        }
    }
}
