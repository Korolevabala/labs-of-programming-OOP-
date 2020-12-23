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


namespace FazulovRushanLaba8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Window1 window1;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Menu_Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Menu_Button_Click_Input(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello Rushan");
            window1 = new Window1();
            window1.Show();
        }

        private void calc_Click(object sender, RoutedEventArgs e)
        {
            if (window1.bool_true == true)
            {
                if (window1.boolean2 == true)
                {
                    MessageBox.Show(window1.area);
                }
                if (window1.boolean1 == true)
                {
                    MessageBox.Show(window1.perimeter);
                }
            }
            else
            {
                MessageBox.Show("Треугольника не существует");
            }
        }

    }
}
