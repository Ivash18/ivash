using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace program9._2_wpf_
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
                
                int N = Convert.ToInt32(n.Text);
                StreamReader fileIn = new StreamReader("C:/Users/vanya/OneDrive/Рабочий стол/out.txt");
                string text = fileIn.ReadToEnd();



                string[] newText = Regex.Split(text, "[ ,.:;]+");

                for (int i = 0; i < newText.Length; i++)
                {
                    if (newText.Length < N) answer.Text = Convert.ToString(newText[i]);
                }
            }
        }
    }
}
