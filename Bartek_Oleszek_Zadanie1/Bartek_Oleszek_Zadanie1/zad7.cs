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
    public partial class zad7 : Form
    {
        public zad7()
        {
            InitializeComponent();
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
            String s = textBox1.Text;
            double x1 = Convert.ToDouble(s);
            s = textBox2.Text;
            double x2 = Convert.ToDouble(s);
            s = textBox3.Text;
            double z = Convert.ToDouble(s);
            int n1 = 10000;
            double wynik;

            bool t = true;
            int i = 1;

            while (t)
            {
                wynik = mTrapezow(x1,x2, n1 - i);
                if ((Math.Truncate(wynik)%z)==0 )
                {
                    textBox4.Text = ("Najmniejsze n dla metody trapezowej wynosi: " + (n1 - i + 1));
                    t = false;
                }
                i++;
            }
            while (t)
            {
                wynik = mProstokatow(x1, x2, n1 - i);
                if ((Math.Truncate(wynik) % z) == 0)
                {
                    textBox4.Text = ("Najmniejsze n dla metody prostokatow wynosi: " + (n1 - i + 1));
                    t = false;
                }
                i++;
            }
        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Metody_Numeryczne m1 = new Metody_Numeryczne();
            m1.ShowDialog();
        }

        private void zad7_Load(object sender, EventArgs e)
        {

        }
    }
}
