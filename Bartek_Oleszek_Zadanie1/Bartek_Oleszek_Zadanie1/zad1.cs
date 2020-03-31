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

            String s = textBox1.Text;
            int m= Convert.ToInt16(s);
            s = textBox2.Text;
            double z = Convert.ToDouble(s);
            // textBox3.Text = Convert.ToString(m + z);
            int n = losuj();
            double calkaPT = mTrapezow(0, 100, n);
            double calkaPP = mProstokatow(0, 100, n);
            double area = Math.Abs(calkaPT % z);
            double wynik;
            List<SingleCount> listaP = new List<SingleCount>();
            for (int i = 0; i < m; i++)
            {
                wynik=mTrapezow(0, 100, m);
                sc = new SingleCount(0, 100, n, AreaType.Trapezoid, area, wynik);
               if(wynik<=calkaPT+area && wynik >= calkaPT - area)
                {
                    listaP.Add(sc);
                }
            }

            for (int i = 0; i < m; i++)
            {
                wynik = mProstokatow(0, 100, m);
                sc = new SingleCount(0, 100, n, AreaType.Trapezoid, area, wynik);
                if (wynik <= calkaPP + area && wynik >= calkaPP - area)
                {
                    listaP.Add(sc);
                }
            }

            g = new Global(listaP);
            
            for(int i=0;i<g.ListOfSingleCount.Count;i++)
            {
                listBox1.Items.Add("Wynik" + g.ListOfSingleCount[i].ToString()+"  ,metoda: "+g.ListOfSingleCount[i].areaType.ToString());

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
    }
}
