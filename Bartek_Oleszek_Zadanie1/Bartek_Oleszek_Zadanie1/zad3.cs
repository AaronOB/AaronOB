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
            String s = textBox1.Text;
            double x1 = Convert.ToDouble(s);
            s = textBox2.Text;
            double x2 = Convert.ToDouble(s);
            int potega = losuj();
            int n = 10;
            double wynik;
            double suma=0;

            for(int i=1;i<=potega;i++)
            {
                n=n*10;
            }
            double calkaPT = mTrapezow(x1, x2, n);

            for (int i=0;i<n;i++)
            {
                wynik = mTrapezow(x1, x2, n);
                suma += (wynik - calkaPT) * (wynik - calkaPT);
               
            }
            suma/=n;
            textBox3.Text = ("Blad sredniokwadratowy : " + (suma));
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
    }
}
