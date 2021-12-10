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

namespace program6._3_wpf_
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
            int[,] Input(out int n)
            {
                n = 0;
                int A = Convert.ToInt32(N.Text);
                int[,] a = new int[A, A];
                for (int i = 0; i < A; ++i)
                    for (int j = 0; j < A; ++j)
                    {
                        Console.Write("a[{0},{1}]= ", i, j);
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
            }

            void Print(int[,] A)
            {
                for (int i = 0; i < A.GetLength(0); ++i, Console.WriteLine())
                    for (int j = 0; j < A.GetLength(1); ++j)
                        Console.Write("{0,5} ", A[i, j]);
            }

            double norm(int[,] A)
            {
                double s = 0, s1 = 0;
                for (int i = 0; i < A.GetLength(0); ++i, s1 = 0)
                {
                    for (int j = 0; j < A.GetLength(1); ++j)
                    {
                        s1 = s1 + A[i, j];
                    }
                    if (s1 > s) s = s1;

                }
                Console.WriteLine("нормa матрицы = " + s);
                return s;
            }

            void Main()
            {
                int n;
                int[,] myArray = Input(out n);
                Console.WriteLine("Исходный массив:");
                Print(myArray);
                norm(myArray);
                Console.ReadKey();

            }
        }
    }
}
