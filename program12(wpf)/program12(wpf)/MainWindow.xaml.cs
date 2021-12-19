﻿using System;
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

namespace program12_wpf_
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
        { }
            class Triangle
        {
            // Поля: int a, b, c;
            int a, b, c;

            //Конструктор, позволяющий создать экземпляр класса  с заданными длинами сторон.
            public Triangle(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public Triangle() { }

            // Методы, позволяющие: вывести длины сторон треугольника на экран;
            public void Show() { Console.WriteLine("Треугольник со сторонами а = {0}, b = {1}, c = {2}", a, b, c); }

            //расчитать периметр треугольника;
            public int Perimeter() { return a + b + c; }

            // расчитать площадь треугольника
            public double Area()
            {
                double HalfPerim = (double)(a + b + c) / 2;
                return Math.Sqrt(HalfPerim * (HalfPerim - a) * (HalfPerim - b) * (HalfPerim - c));
            }

            // Свойства: позволяющее получить-установить длины сторон треугольника (доступное для чтения и записи);
            public int A
            {
                get { return a; }
                set { a = value; }
            }

            public int B
            {
                get { return b; }
                set { b = value; }
            }

            public int C
            {
                get { return c; }
                set { c = value; }
            }

            // позволяющее установить, существует ли треугольник с данными длинами сторон (доступное только для чтения).
            public bool isTriangle
            {
                get
                {
                    if (a + b > c && a + c > b && b + c > a)
                        return true;
                    return false;
                }
            }

            // Индексатор, позволяющий по индексу 0 обращаться к полю a, по индексу 1 – к полю b, по индексу 2 – к полю c, при других значениях индекса выдается сообщение об ошибке.
            public int this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 1:
                            return a;
                        case 2:
                            return b;
                        case 3:
                            return c;
                        default:
                            throw new Exception("Error");
                    }
                }
            }

            // операции ++ (--): одновременно увеличивает (уменьшает) значение полей a, b и c на 1;
            public static Triangle operator ++(Triangle obj)
            {
                obj.a++;
                obj.b++;
                obj.c++;
                return obj;
            }

            public static Triangle operator --(Triangle obj)
            {
                obj.a--;
                obj.b--;
                obj.c--;
                return obj;
            }

            // констант true и false: обращение к экземпляру класса дает значение true, если треугольник с заданными длинами сторон существует, иначе false;
            public static bool operator false(Triangle obj)
            {
                return obj.isTriangle;
            }

            public static bool operator true(Triangle obj)
            {
                return obj.isTriangle;
            }

            // операции *:  одновременно домножает поля a, b и c на скаляр;
            public static Triangle operator *(Triangle obj, int skal)
            {
                obj.a *= skal;
                obj.b *= skal;
                obj.c *= skal;
                return obj;
            }

            public static Triangle operator *(int skal, Triangle obj)
            {
                obj.a *= skal;
                obj.b *= skal;
                obj.c *= skal;
                return obj;
            }

            //преобразования типа Triangle в string (и наоборот)
            public static explicit operator String(Triangle tr)
            {
                return tr.a + ", " + tr.b + ", " + tr.c;
            }

            public static explicit operator Triangle(string str)
            {
                string[] q = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Triangle tr = new Triangle();
                tr.a = int.Parse(q[0]);
                tr.b = int.Parse(q[1]);
                tr.c = int.Parse(q[2]);
                return tr;
            }
        }
        class Program
        {
            void Main(string[] args)
            {
                int a, b, c;

                
                a = Int32.Parse(Console.ReadLine());
                
                b = Int32.Parse(Console.ReadLine());
              
                c = Int32.Parse(Console.ReadLine());

                Triangle obj = new Triangle(a, b, c);
            
                obj.Show();
                Console.WriteLine();

                Console.WriteLine(obj.Perimeter());
                Console.WriteLine();

               
                Console.WriteLine(obj.Area());
                Console.WriteLine();

               
                obj.A = 7;
                obj.B = 7;
                obj.C = 7;
                obj.Show();
                Console.WriteLine();

                
                Console.WriteLine(obj.isTriangle);
                Console.WriteLine();

               
                obj++;
                obj.Show();
                Console.WriteLine();

              
                obj--;
                obj.Show();
                Console.WriteLine();

                
                obj = obj * 5;
                obj.Show();
                Console.WriteLine();

               
                obj = 4 * obj;
                obj.Show();
                Console.WriteLine();

               
                string str = (string)obj;
                Console.WriteLine(  str);
                Console.WriteLine();

                
                Triangle obj_new = (Triangle)str;
                obj_new.Show();
                Console.WriteLine();

                Console.ReadLine();
            }
        }
    }
}

