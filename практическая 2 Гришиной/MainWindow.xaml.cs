using System;
using Lib2;
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
using Пример_таблицы_WPF;

namespace практическая_2_Гришиной
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] mas;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void range_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void mas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Fill_Click_(object sender, RoutedEventArgs e)
        {
            //получение диапазона 
            int range1 = Convert.ToInt32(range.Text);
            // ввод количества ячеек из TextBox
           int Kol = Convert.ToInt32(columns.Text);
           // Заполнение таблицы с использованием рандома 
           Lib2.Class1.Massiv(out mas , Kol, range1);//призыв метода
            //вывод массива
            mas1.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int com;
            Lib2.Class1.Compos(out com, mas); // призыв метода 
            string comSTR = com.ToString();
            // вывод произведения 
            com1.Text = comSTR.ToString();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void com1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
