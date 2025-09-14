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
    public partial class Problema2 : Form
    {
        public Problema2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textDatos.Text, out int numero))
            {
                int resultado = InvertirNumero(numero, 0);
                textResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private int InvertirNumero(int numero, int invertido)
        {
            if (numero == 0)
            {
                return invertido;
            }
            else
            {
                int digito = numero % 10;
                invertido = invertido * 10 + digito;
                return InvertirNumero(numero / 10, invertido);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonInversor.Enabled = !string.IsNullOrWhiteSpace(textDatos.Text);
        }
    }
}
