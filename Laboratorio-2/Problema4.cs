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
    public partial class Problema4 : Form
    {
        public Problema4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstDivisores.Items.Clear();
            int n;
            if (int.TryParse(txtNumero.Text, out n) && n > 0)
            {
                int suma = 0;

                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        lstDivisores.Items.Add(i); 
                        suma += i;                 
                    }
                }

                lstDivisores.Items.Add("-----------------------");

                
                if (suma == n)
                {
                    lstDivisores.Items.Add($"{n} SI es un número perfecto.");
                }
                else
                {
                    lstDivisores.Items.Add($"{n} NO es un número perfecto.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo válido.");
            }
        }
    }
}
