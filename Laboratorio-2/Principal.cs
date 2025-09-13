using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Problema1 p1 = new Problema1();
            p1.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Problema2 p2 = new Problema2();
            p2.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Problema3 p3 = new Problema3();
            p3.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Problema4 p4 = new Problema4();
            p4.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Problema5 p5 = new Problema5();
            p5.Show();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Problema6 p6 = new Problema6();
            p6.Show();
        }
    }
}
