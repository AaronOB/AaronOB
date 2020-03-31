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
    public partial class zad6 : Form
    {
        public zad6()
        {
            InitializeComponent();
        }

        private int losuj()
        {
            Random r = new Random();
            int x = r.Next(10, 1000);
            return x;
        }

        private static double f1(double x)
        {
            return x * x * x;
        }

        private static double f2(double x)
        {
            return x * x;
        }

        private static double mTrapezow(double x1, double x2, int n, double fun)
        {
            double dx, calka;

            dx = (x2 - x1) / (double)n;

            calka = 0;
            if (fun == 1)
            {
                for (int i = 1; i < n; i++)
                {
                    calka += f1(x1 + i * dx);
                }
                calka += (f1(x1) + f1(x2)) / 2;
                calka *= dx;

            }

            else
            {
                for (int i = 1; i < n; i++)
                {
                    calka += f2(x1 + i * dx);
                }
                calka += (f2(x1) + f2(x2)) / 2;
                calka *= dx;
            }

            return calka;
        }

        private static double mProstokatow(double x1, double x2, int n, double fun)
        {
            double dx, calka;

            dx = (x2 - x1) / (double)n;

            calka = 0;

            if (fun == 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    calka += f1(x1 + i * dx);
                }
                calka *= dx;
            }

            else
            {
                for (int i = 1; i <= n; i++)
                {
                    calka += f2(x1 + i * dx);
                }
                calka *= dx;
            }

            return calka;
        }

        private void oblicz1_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            double k = Convert.ToDouble(s);
            s = textBox1.Text;
            double m = Convert.ToDouble(s);

        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Metody_Numeryczne m1 = new Metody_Numeryczne();
            m1.ShowDialog();
        }

        private void zad6_Load(object sender, EventArgs e)
        {

        }
    }
}
