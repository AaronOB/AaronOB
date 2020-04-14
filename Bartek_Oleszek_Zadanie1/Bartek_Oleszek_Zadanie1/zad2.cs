using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bartek_Oleszek_Zadanie1.Models;

namespace Bartek_Oleszek_Zadanie1
{
    public partial class zad2 : Form
    {
        public zad2()
        {
            InitializeComponent();
        }

        private static double f(double x)
        {
            return x*x*x;
        }

        private static double mTrapezow(double x1, double x2, int n)
        {
            double dx, calka;

            dx = (x2 - x1) / (double)n;

            calka = 0;
            for (int i = 1; i < n; i++)
            {
                calka += f(x1 + i * dx);
            }
            calka += (f(x1) + f(x2)) / 2;
            calka *= dx;

            return calka;
        }

        private static double mProstokatow(double x1, double x2, int n)
        {
            double dx, calka;

            dx = (x2 - x1) / (double)n;

            calka = 0;
            for (int i = 1; i <= n; i++)
            {
                calka += f(x1 + i * dx);
            }
            calka *= dx;

            return calka;
        }

        private void oblicz1_Click(object sender, EventArgs e)
        {
            try
            {

                String s = textBox2.Text;
                double z = Convert.ToDouble(s);
                int n1 = 10000;
                double calkaPT = mTrapezow(0, 100, n1);
                double calkaPP = mProstokatow(0, 100, n1);
                double area = Math.Abs(calkaPT % z);
                double area2 = Math.Abs(calkaPP % z);
                double wynik;

                bool t = true;
                int i = 1, j = 1; ;

                while (t)
                {
                    wynik = mTrapezow(0, 100, i);
                    if (wynik >= calkaPT - area && wynik <= calkaPT + area)
                    {
                        t = false;
                    }
                    i++;
                }

                while (t)
                {
                    wynik = mProstokatow(0, 100, j);
                    if (wynik >= calkaPP - area2 && wynik <= calkaPP + area2)
                    {
                        t = false;
                    }
                    j++;
                }
                textBox1.Text = ("Najmniejsze 'n' dla metody trapezowej wynosi: " + (i) + " ,a dla metody prostokątnej wynosi: " + (j));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Powrót_Click(object sender, EventArgs e)
        {
            this.Hide();
            Metody_Numeryczne m1 = new Metody_Numeryczne();
            m1.ShowDialog();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zad2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
