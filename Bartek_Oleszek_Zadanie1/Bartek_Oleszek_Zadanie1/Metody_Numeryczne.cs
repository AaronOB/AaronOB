using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartek_Oleszek_Zadanie1
{
    public partial class Metody_Numeryczne : Form
    {
        public Metody_Numeryczne()
        {
            InitializeComponent();
        }

        private void zad1Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            zad1 z1 = new zad1();
            z1.ShowDialog();
        }

        private void zad2Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            zad2 z2 = new zad2();
            z2.ShowDialog();
        }

        private void zad3Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            zad3 z3 = new zad3();
            z3.ShowDialog();
        }

        private void zad4Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            zad4 z4 = new zad4();
            z4.ShowDialog();
        }

        private void zad5Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            zad5 z5 = new zad5();
            z5.ShowDialog();
        }

        private void zad6Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            zad6 z6 = new zad6();
            z6.ShowDialog();
        }

        private void zad7Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            zad7 z7 = new zad7();
            z7.ShowDialog();
        }

        private void zad8Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            zad8 z8 = new zad8();
            z8.ShowDialog();
        }

        private void wyjscieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
