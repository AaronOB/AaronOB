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
using System.Threading;

namespace Bartek_Oleszek_Zadanie1
{
    public partial class zad5 : Form
    {
        public zad5()
        {
            InitializeComponent();
        }
        private int losuj()
        {
            Random r = new Random();
            int x = r.Next(0, 100);
            return x;
        }


        private static double f1(double x)
        {
            return x * x * x;
        }

        private static double f2(double x)
        {
            return x * x ;
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

        private static double mProstokatow(double x1, double x2, int n,double fun)
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
            try
            {
                String s = textBox1.Text;
                double k = Convert.ToDouble(s);
                double wynik = 1,w1=0,w2=0;
                int x1p, x2p, x1t, x2t,t;
                SingleCount min1p = new SingleCount();
                SingleCount min2p = new SingleCount();
                SingleCount min1t = new SingleCount();
                SingleCount min2t = new SingleCount();

                if (k > 5)
                {
                    throw new Exception("Podaj liczbę 'k' mniejszą od 6");
                }

                int n = 10;

                for (int i = 0; i < k; i++)
                {
                    n = n * 10;
                }

                do
                {
                    x1p = losuj();
                    Thread.Sleep(1);
                    x2p = losuj();
                    while (x1p == x2p)
                        x2p = losuj();

                    Thread.Sleep(10);
                    x1t = losuj();
                    Thread.Sleep(1);
                    x2t = losuj();

                    while (x1t == x2t)
                        x2t = losuj();

                    if (x1p > x2p)
                    {
                        t = x2p;
                        x2p = x1p;
                        x1p = t;
                    }

                    if (x1t > x2t)
                    {
                        t = x2t;
                        x2t = x1t;
                        x1t = t;
                    }

                    if (x1p != x1t)
                    {
                        wynik = w1 - w2;
                        w1 = mProstokatow(x1p, x2p, n, 1);
                        w2 = mProstokatow(x1t, x2t, n, 2);
                    }
                    
                    if (wynik == 0 && x1p != x1t)
                    {
                        min1t = new SingleCount(x1p, x2p, 1000, AreaType.Rectangle, 0, w1);
                        min2t = new SingleCount(x1t, x2t, 1000, AreaType.Rectangle, 0, w2);

                    }

                } while(wynik==0);

                textBox2.Text = ("Dla metody prostokątna wynosi obie całki dla różnych funkcji są równe dla wartości: " + " x1:" + min1t.x1.ToString() + "   ,x2:" + min1t.x2.ToString() + "  \n x1:" + min2t.x1.ToString() + "   ,x2:" + min2t.x2.ToString());
                   
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void zad5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}
