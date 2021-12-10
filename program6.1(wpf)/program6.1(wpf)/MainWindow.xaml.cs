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

namespace program6._1_wpf_
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
                

                int n = int.Parse(Console.ReadLine());

                Random random = new Random();

                int[] arr = new int[n];

                

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(5, 20);
                    answer.Text = Convert.ToString(arr[i] + " ");
                }
               
                int CH;
                CH = Convert.ToInt32(ch.Text);
                

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > CH)
                    {
                        answer.Text = Convert.ToString(i + " ");
                    }
                }

                
  
                int n1 = int.Parse(Console.ReadLine());
                
                int m = int.Parse(Console.ReadLine());
                int[,] multyArr = new int[n1, m];

                for (int i = 0; i < multyArr.GetLength(0); i++)
                {
                    for (int j = 0; j < multyArr.GetLength(1); j++)
                    {
                        multyArr[i, j] = random.Next(5, 20);
                        answer.Text = Convert.ToString(multyArr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                int ch1 = int.Parse(Console.ReadLine());
                

                for (int i = 0; i < multyArr.GetLength(0); i++)
                {
                    for (int j = 0; j < multyArr.GetLength(1); j++)
                    {
                        if (multyArr[i, j] > ch1)
                        {
                            answer.Text = Convert.ToString(("{0} {1} ", i, j));
                        }
                    }
                }
            }
        }
    }
}
