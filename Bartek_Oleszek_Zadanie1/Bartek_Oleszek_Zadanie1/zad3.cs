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
    public partial class zad3 : Form
    {

        public zad3()
        {
            InitializeComponent();
        }
        private int losuj()
        {
            Random r = new Random();
            int i = r.Next(1, 6);
            return i;
        }

        private static double f(double x)
        {
            return x * x;
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
                double x1 = Convert.ToDouble(s);
                s = textBox2.Text;
                double x2 = Convert.ToDouble(s);

                if (x1 > 100 || x2 > 100)
                {
                    throw new Exception("x1 i x2 muszą być z przedziału 0 do 100");
                }
                int n = 10;
                int potega = losuj();

                for (int i = 1; i < potega; i++)
                {
                    n = n * 10;
                }
                double wynik;
                double sumaT = 0, sumaP = 0;

                double calkaPT = mTrapezow(x1, x2, 100000);
                double calkaPP = mProstokatow(x1, x2, 100000);

                for (int i = 0; i < n; i++)
                {
                    wynik = mTrapezow(x1, x2, n);
                    sumaT += (wynik - calkaPT) * (wynik - calkaPT);

                }
                sumaT /= n;

                for (int i = 0; i < n; i++)
                {
                    wynik = mProstokatow(x1, x2, n);
                    sumaP += (wynik - calkaPP) * (wynik - calkaPP);
                }
                sumaP /= n;
                //textBox3.Text = ("Błąd średniokwadratowy dla metody trapezowej: " + (sumaT) + ", \n dla metody prostokątnej: " + (sumaP));
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zad3_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
