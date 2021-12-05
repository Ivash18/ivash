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

namespace program3._1
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

        private void answer_Click(object sender, RoutedEventArgs e)
        {
            int X,X1,X2,X3;
            X = Convert.ToInt32(x.Text);
            X1 = X % 10;
            X2 = X / 100;
            X3 = X / 10 % 10;
            output.Text = Convert.ToString(X1.ToString() + X3.ToString()+ X2.ToString());
        }
    }
}
    

