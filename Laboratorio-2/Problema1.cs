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
                lstVentas.Items.Add($"La sumatoria total es: {sumaTotal(arr)}");
                lstVentas.Items.Add($"La sumatoria de mayores a 1000 es: {sumaMayorA1000(arr)}");
                lstVentas.Items.Add($"La sumatoria de menores a 1000 es: {sumaMenorA1000(arr)}");
                lstVentas.Items.Add($"La sumatoria de menores a 500 es: {sumaMenorA500(arr)}");

                txtMa1000.Text = Convert.ToString(mayorA1000(arr));
                txtMe1000.Text = Convert.ToString(menorA1000(arr));
                txtMe500.Text = Convert.ToString(menorA500(arr));
            }
            else
            {
                MessageBox.Show("Verifique los datos ingrese");
            }
        }
        private double mayorA1000(double[] a)
        {

            double Ma1000 = 0;

            foreach (double dato in a)
            {
                if (dato > 1000) {
                    Ma1000++;
                }
            }
            return Ma1000;
        }
        private double sumaMayorA1000(double[] a)
        {
            double suma = 0;

            foreach (double dato in a)
            {
                if (dato > 1000)
                {
                    suma = suma + dato;
                }
            }
            return suma;
        }
        private double menorA1000(double[] a)
        {

            double Me1000 = 0;

            foreach (double dato in a)
            {
                if (dato <= 1000 && dato >500)
                {
                    Me1000++;
                }
            }
            return Me1000;
        }
        private double sumaMenorA1000(double[] a)
        {
            double suma = 0;

            foreach (double dato in a)
            {
                if (dato <= 1000 && dato > 500)
                {
                    suma = suma + dato;
                }
            }
            return suma;
        }

        private double menorA500(double[] a)
        {
            double Me500 = 0;

            foreach (double dato in a)
            {
                if (dato <= 500)
                {
                    Me500++;
                }
            }
            return Me500;
        }
        private double sumaMenorA500(double[] a)
        {
            double suma = 0;

            foreach (double dato in a)
            {
                if (dato <= 500)
                {
                    suma = suma + dato;
                }
            }
            return suma;
        }
        private double sumaTotal(double[] a)
        {
            double suma = 0;
            foreach (double dato in a)
            {
                suma += dato;
            }
            return suma;
        }

    } 
}
