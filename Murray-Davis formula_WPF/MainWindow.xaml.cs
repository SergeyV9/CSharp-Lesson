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

namespace Murray_Davis_formula_WPF
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


        Calculation MyCalc = new Calculation();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MyCalc.TestF();
            //MyCalc.TestF(1, 3);
            //MyCalc.MDev(1.457, 0.48);

            double MyRezalt = MyCalc.MDev(double.Parse(tb_Ds.Text), double.Parse(tb_Dr.Text));


            tb_Dot.Text = string.Concat(MyRezalt);
            //tb_Dot.Text = string.Concat(MyCalc.MDev(1.457, 0.48));


            //MessageBox.Show(string.Concat(MyRezalt));

        }
    }
}
