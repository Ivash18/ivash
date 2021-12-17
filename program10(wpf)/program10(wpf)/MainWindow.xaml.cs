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

namespace program10_wpf_
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

        private void n_TextChanged(object sender, TextChangedEventArgs e)
        {
            void Main(string[] args)
            {
                if (!Directory.Exists("C:/Users/vanya/OneDrive/Рабочий стол"))
                {
                    Directory.CreateDirectory("C:/Users/vanya/OneDrive/Рабочий стол");
                }
                Directory.CreateDirectory("C:/Users/vanya/OneDrive/Рабочий стол/temp/k1");
                Directory.CreateDirectory("C:/Users/vanya/OneDrive/Рабочий стол/temp/k2");
                StreamWriter sw = new StreamWriter("C:/Users/vanya/OneDrive/Рабочий стол/temp/k1/t1.txt");
                sw.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
                sw.Close();
                sw = new StreamWriter("C:/Users/vanya/OneDrive/Рабочий стол/temp/k1/t2.txt");
                sw.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
                sw.Close();
                sw = new StreamWriter("C:/Users/vanya/OneDrive/Рабочий стол/temp/k2/.txt");
                StreamReader sr = new StreamReader("C:/Users/vanya/OneDrive/Рабочий стол/temp/k1/t1.txt");
                sw.WriteLine(sr.ReadToEnd());
                sr.Close();
                sr = new StreamReader("C:/Users/vanya/OneDrive/Рабочий стол/temp/k1/t2.txt");
                sw.WriteLine(sr.ReadToEnd());
                sr.Close();
                sw.Close();
                File.Move("C:/Users/vanya/OneDrive/Рабочий стол/temp/k1/t2.txt", "C:/Users/vanya/OneDrive/Рабочий стол/temp/k2/t2.txt");
                File.Copy("C:/Users/vanya/OneDrive/Рабочий стол/temp/k1/t1.txt", "C:/Users/vanya/OneDrive/Рабочий стол/temp/k2/t1.txt");
                Directory.Move("C:/Users/vanya/OneDrive/Рабочий стол/temp/k2", "C:/Users/vanya/OneDrive/Рабочий стол/temp/ALL");
                Directory.Delete("C:/Users/vanya/OneDrive/Рабочий стол/temp/k1", true);
                DirectoryInfo dinf = new DirectoryInfo("C:/Users/vanya/OneDrive/Рабочий стол/temp/ALL");
                FileInfo[] finf = dinf.GetFiles();
                foreach (FileInfo fi in finf)
                {
                    n.Text = Convert.ToString(fi.FullName.ToString() + fi.Attributes.ToString());//в скобках могут быть другая нужная тебе инфа
                }
            }
        }
    }
}
