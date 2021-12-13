using System;
using System.Collections.Generic;
using System.IO;
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

namespace program9._1_wpf_
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
                Random r = new Random();
                Console.Write("N = ");
                int N = Convert.ToInt32(n.Text);
                var a = Enumerable.Range(0, N).Select(v => r.NextDouble() * (10 + 10) - 10);
                double average = a.Where((v, i) => i % 2 != 0).Average();
                File.WriteAllText("C:/Users/vanya/OneDrive/Рабочий стол/output.txt", String.Join(" ", a));
                answer.Text = Convert.ToString($"Среднее арифметическое элементов на чётных позициях = {average}");
                Console.ReadKey();
            }
        }
    }
}
