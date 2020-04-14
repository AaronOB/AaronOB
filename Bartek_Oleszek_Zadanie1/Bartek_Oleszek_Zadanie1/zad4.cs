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
    public partial class zad4 : Form
    {
        public zad4()
        {
            InitializeComponent();
        }

        private static double f(double x)
        {
            return x * x * x;
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
                String s = textBox1.Text;
                int x1 = Convert.ToInt32(s);
                s = textBox2.Text;
                int x2 = Convert.ToInt32(s);
                s = textBox3.Text;
                double k = Convert.ToDouble(s);
                s = textBox4.Text;
                double z = Convert.ToDouble(s);

                int n = 10;
                for (int j = 1; j <= k; j++)
                {
                    n = n * 10;
                }
                double wynik;

                bool t = true;

                int x1T = x1;
                int x2T = x2;

                int x1P = x1;
                int x2P = x2;

                while (t)
                {

                    for (int j = x1T + 1; j <= 100 && t == true; j++)
                    {
                        x2T = j;
                        wynik = mTrapezow(x1T, x2T, n);
                        if ((Math.Truncate(wynik) % z) == 0)
                        {
                            t = false;
                        }
                        j++;

                    }
                    x1T++;

                }

                t = true;
                while (t)
                {

                    for (int j = x1P + 1; j <= 100 && t == true; j++)
                    {
                        x2P = j;
                        wynik = mProstokatow(x1P, x2P, n);
                        if ((Math.Truncate(wynik) % z) == 0)
                        {
                            t = false;
                        }
                        j++;
                    }
                    x1P++;
                }

                textBox5.Text = ("Dla metody trapezowej x1: " + (x1T - 1) + "  ,x2: " + x2T + " ,\n dla metody prostokątów x1: " + (x1P - 1) + "  ,x2: " + x2P);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Metody_Numeryczne m1 = new Metody_Numeryczne();
            m1.ShowDialog();
        }

        private void zad4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
