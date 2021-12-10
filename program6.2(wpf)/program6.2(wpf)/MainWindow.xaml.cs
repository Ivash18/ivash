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

namespace program6._2_wpf_
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
                int max = 0, coord_min = 0, min, coord_max = 0, tmp = 0;
                int A;
                A = Convert.ToInt32(a.Text);
                
                Random r = new Random();
                int[] mas = new int[A];
                for (int i = 0; i < A; i++)
                    mas[i] = r.Next(0, 100);

                min = mas[0];
                for (int i = 0; i < A; i++)
                    Console.Write(mas[i] + " ");
                for (int i = 0; i < A; i++)
                    if (mas[i] > max) { max = mas[i]; coord_max = i; }
                for (int i = 0; i < A; i++)
                    if (mas[i] < min) { min = mas[i]; coord_min = i; }

                tmp = mas[coord_min];
                mas[coord_min] = mas[coord_max];
                mas[coord_max] = tmp;
                for (int i = 0; i < A; i++)
                    answer.Text = Convert.ToString(mas[i] + " ");
                Console.ReadKey();

            }
        }
    }
}
