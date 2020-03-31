﻿using System;
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
            String s = textBox2.Text;
            double z = Convert.ToDouble(s);
            int n1 = 10000;
            double calkaPT = mTrapezow(0, 100, n1);
            double area = Math.Abs(calkaPT % z);
            double wynik;

            bool t = true;
            int i = 1;

            while (t)
            {
                wynik = mTrapezow(0, 100, n1-i);
                if (Math.Abs(wynik - calkaPT) >area)
                {
                    textBox1.Text = ("Najmniejsze n wynosi: "+(n1-i+1));
                    t = false;
                }
                i++;
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
    }
}