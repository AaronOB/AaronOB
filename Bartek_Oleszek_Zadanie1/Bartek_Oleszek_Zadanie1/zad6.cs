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
    public partial class zad6 : Form
    {
        public zad6()
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
            try
            {
                String s = textBox1.Text;
                int k = Convert.ToInt16(s);
                s = textBox2.Text;
                int m = Convert.ToInt16(s);
                int n = 10;
                double wynik1,wynik2;
                double MIN1 = Double.MaxValue;
                double MIN2 = Double.MaxValue;
                SingleCount min1p=new SingleCount();
                SingleCount min2p=new SingleCount();
                SingleCount min1t = new SingleCount();
                SingleCount min2t = new SingleCount();

                if (k > 5)
                {
                    throw new Exception("Podaj liczbę 'k' mniejszą od 6");
                }

                else if (m > 100)
                {
                    throw new Exception("Podaj liczbę 'm' mniejszą od 100");
                }

                for(int i=1;i<k;i++)
                {
                    n = n * 10;
                }

                int[,] tablica1 = new int[2, m];
                int[,] tablica2 = new int[2, m];

                int a, b,a2,b2;
                for (int i=0;i<m;i++)
                {
                    a = losuj();
                    Thread.Sleep(1);
                    b = losuj();
                    while (a == b)
                        b = losuj();

                    a2 = losuj();
                    Thread.Sleep(1);
                    b2 = losuj();

                    while (a2 == b2)
                        b2 = losuj();

                    if (a>b)
                    {
                        tablica1[0, i] = b;
                        tablica1[1, i] = a;
                    }

                    else if(a<=b)
                    {
                        tablica1[0, i] = a;
                        tablica1[1, i] = b;
                    }

                    if (a2 > b2)
                    {
                        tablica2[0, i] = b2;
                        tablica2[1, i] = a2;
                    }

                    else if(a2>=b2)
                    {
                        tablica2[0, i] = a2;
                        tablica2[1, i] = b2;
                    }
                }

                List<SingleCount> listaP = new List<SingleCount>();
                for (int i = 0; i < m; i++)
                {
              
                    wynik1 = mProstokatow(tablica1[0,i], tablica1[1,i], n,1);
                    wynik2 = mProstokatow(tablica2[0, i], tablica2[1, i], n, 2);
                    
                    if (MIN1 > Math.Abs(wynik1 - wynik2))
                    {
                        min1p = new SingleCount(tablica1[0, i], tablica1[1, i], 1000, AreaType.Trapezoid, 0, wynik1);
                        min2p = new SingleCount(tablica2[0, i], tablica2[1, i], 1000, AreaType.Trapezoid, 0, wynik2);
                        MIN1 = Math.Abs(wynik1 - wynik2);
                    }

                    wynik1 = mTrapezow(tablica1[0, i], tablica1[1, i], n, 1);
                    wynik2 = mTrapezow(tablica2[0, i], tablica2[1, i], n, 2);

                    if (MIN2 > Math.Abs(wynik1 - wynik2))
                    {
                        min1t = new SingleCount(tablica1[0, i], tablica1[1, i], 1000, AreaType.Trapezoid, 0, wynik1);
                        min2t = new SingleCount(tablica2[0, i], tablica2[1, i], 1000, AreaType.Trapezoid, 0, wynik2);
                        MIN2 = Math.Abs(wynik1 - wynik2);
                    }

                }
                textBox3.Text = ("Najmniejsza różnica dla metody prostokątna wynosi: " + MIN1 + " wynik1:" + min1p.calculationNumber.ToString() + "   ,wynik2:" + min2p.calculationNumber.ToString()+
                    "\n \n Najmniejsza różnica dla metody trapezowej wynosi: " + MIN2 + " wynik1:" + min1t.calculationNumber.ToString() + "   ,wynik2:" + min2t.calculationNumber.ToString());

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

        private void zad6_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
