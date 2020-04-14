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
    public partial class zad1 : Form
    {
        
        public zad1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int losuj()
        {
            Random r = new Random();
            int n = r.Next(10, 100000);
            return n;
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
            Global g;
            SingleCount sc;
            String s;
            int m=10;

            try
            {
                s = textBox1.Text;
                m = Convert.ToInt16(s);

                if (m > 100)
                {
                    throw new Exception("Podaj liczbę 'm' mniejszą od 100");
                }

                else
                {
                    s = textBox2.Text;
                    double z = Convert.ToDouble(s);

                    int n = losuj();
                    double calkaPT = mTrapezow(0, 100, n);
                    double calkaPP = mProstokatow(0, 100, n);
                    double area = Math.Abs(calkaPT % z);
                    double wynik;
                    List<SingleCount> listaP = new List<SingleCount>();
                    for (int i = 0; i < m; i++)
                    {
                        n = losuj();
                        wynik = mTrapezow(0, 100, n);
                        sc = new SingleCount(0, 100, n, AreaType.Trapezoid, area, wynik);
                        if (wynik <= calkaPT + area && wynik >= calkaPT - area)
                        {
                            listaP.Add(sc);
                        }


                    }

                    for (int i = 0; i < m; i++)
                    {
                        n = losuj();
                        wynik = mProstokatow(0, 100, n);
                        sc = new SingleCount(0, 100, n, AreaType.Rectangle, area, wynik);
                        if (wynik <= calkaPP + area && wynik >= calkaPP - area)
                        {
                            listaP.Add(sc);
                        }
                    }

                    g = new Global(listaP);

                    for (int i = 0; i < g.ListOfSingleCount.Count; i++)
                    {
                        listBox1.Items.Add("Wynik: " + g.ListOfSingleCount[i].calculationNumber.ToString() + "   , metoda: " + g.ListOfSingleCount[i].areaType.ToString());

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Metody_Numeryczne m1 = new Metody_Numeryczne();
            m1.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zad1_Load(object sender, EventArgs e)
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
    }
}
