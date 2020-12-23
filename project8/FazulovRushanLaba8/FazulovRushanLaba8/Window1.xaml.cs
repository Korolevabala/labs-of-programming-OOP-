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
using System.Windows.Shapes;

namespace FazulovRushanLaba8
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        string first, second, third;
        public string area, perimeter;//площадь и периметр
        public bool boolean1 = false;
        public bool boolean2 = false;
        public bool bool_true = false;
        private void True (int a, int b, int c)
        {
            if((a+b>c) && (a+c>b) && (c+b>a))
            {
                bool_true = true;
            }
        }
        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            second = textbox2.Text;
        }

        private void checkBox_Checked_S(object sender, RoutedEventArgs e)
        {
           boolean2 = true;
           area = Convert.ToString(Convert.ToInt32(first) * Convert.ToInt32(second) * Convert.ToInt32(third));
            //MessageBox.Show(area);
            True(Convert.ToInt32(first), Convert.ToInt32(second), Convert.ToInt32(third));
        }

        private void checkBox_Checked_P(object sender, RoutedEventArgs e)
        {
            boolean1 = true;
            perimeter = Convert.ToString(Convert.ToInt32(first) + Convert.ToInt32(second) + Convert.ToInt32(third));
            True(Convert.ToInt32(first), Convert.ToInt32(second), Convert.ToInt32(third));
            //MessageBox.Show(perimeter);
        }

        private void textbox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            third = textbox3.Text;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            first = textbox1.Text;
        }
        private void checkBox_UncheckedP(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox_P.Content.ToString() + " не отмечен");
        }

        private void checkBox_IndeterminateP(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox_P.Content.ToString() + " в неопределенном состоянии");
        }
        private void checkBox_UncheckedS(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox_S.Content.ToString() + " не отмечена");
        }

        private void checkBox_IndeterminateS(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox_S.Content.ToString() + " в неопределенном состоянии");
        }
    }
}
