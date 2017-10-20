using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Murray_Davis_formula_WPF
{
    public class Calculation
    {

        public void TestF()
        {

            MessageBox.Show("ha ha");

        }

        public void TestF(int a, int b)
        {
            int c = 10;
            c = +a / b;
            MessageBox.Show("C равно " + c);

        }

        public double MDev(double a, double b)
        {

            double c = 100 * ((1 - Math.Pow(10, -b)) / (1 - Math.Pow(10, -a)));

            return (c);

            //MessageBox.Show("Растровая плашка равна " + c + "%");

        }


    }
}
