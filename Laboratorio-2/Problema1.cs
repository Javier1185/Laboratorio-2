using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Laboratorio_2
{
    public partial class Problema1 : Form
    {
        public Problema1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int cantidadV = 0;
            int c = 0;
            double n;
            double [] arr;
            lstVentas.Items.Clear();
            if (int.TryParse(txtCantidadVentas.Text, out cantidadV) && cantidadV > 0)
            {
                arr = new double [cantidadV];
                while (c < cantidadV)
                {
                    string entrada = Interaction.InputBox($"Ingrese el valor para la posición #{c}", "Entrada", "0");
                    if (double.TryParse(entrada, out n))
                    {
                        arr[c] = n;
                        lstVentas.Items.Add(n);
                        c++;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un numero correctamente");
                    }
                }
                Class1 obj = new Class1();

                lstVentas.Items.Add($"La sumatoria total es: {obj.sumaTotal(arr)}");
                lstVentas.Items.Add($"La sumatoria de mayores a 1000 es: {obj.sumaMayorA1000(arr)}");
                lstVentas.Items.Add($"La sumatoria de menores a 1000 es: {obj.sumaMenorA1000(arr)}");
                lstVentas.Items.Add($"La sumatoria de menores a 500 es: {obj.sumaMenorA500(arr)}");

                txtMa1000.Text = Convert.ToString(obj.mayorA1000(arr));
                txtMe1000.Text = Convert.ToString(obj.menorA1000(arr));
                txtMe500.Text = Convert.ToString(obj.menorA500(arr));
            }
            else
            {
                MessageBox.Show("Verifique los datos ingrese");
            }
        }
  
        private void txtMa1000_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    } 
}
