using System;
using System.IO;
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
using Microsoft.Win32;

namespace WPF_Elements
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

            

            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "Текст(*.txt)|*.TXT" + "|Все файлы (*.*)|*.* ";
            //myDialog.Title = "Открыть файл";
            //myDialog.FileName = "Document";
            if (myDialog.ShowDialog() == true)
            {
                //MessageBox.Show(myDialog.FileName);

                string mypatch = myDialog.FileName;

                string[] spline = File.ReadAllLines(mypatch);
                string[,] myresut = new string[spline.Length, 5];
                string mywords = "";

                for (int i = 0; i < spline.Length; i++)
                {
                    mywords = spline[i];
                    string[] split = mywords.Split(new Char[] { ' '/*, ',', '.', ':', '\t' */});

                    MyTB.Text += "\n";

                    for (int j = 0; j < 5; j++)
                    {
                        myresut.SetValue(split[j], i, j);
                        //MessageBox.Show(myresut[i, j]);
                        MyTB.Text += myresut[i, j] + " ";

                    }

                }





            }

        }

        private void textBlock_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
