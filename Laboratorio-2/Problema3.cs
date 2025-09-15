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
    public partial class Problema3 : Form
    {
        private int totalHombres = 0;
        private int totalMujeres = 0;
        private int hombresMayores40 = 0;
        private int mujeresEntre18y25 = 0;

        public Problema3()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGenero.Text, out int genero))
            {
                if (genero == 0)
                {
                    MessageBox.Show("Registro de datos finalizado. Ahora presiona 'Calcular'.");
                    txtGenero.Enabled = false;
                    txtEdad.Enabled = false;
                    btnRegistrar.Enabled = false;
                    return;
                }

                if (genero == 1 || genero == 2)
                {
                    if (int.TryParse(txtEdad.Text, out int edad) && edad > 0)
                    {
                        if (genero == 1) // Mujer
                        {
                            totalMujeres++;
                            if (edad >= 18 && edad <= 25)
                                mujeresEntre18y25++;
                        }
                        else if (genero == 2) // Hombre
                        {
                            totalHombres++;
                            if (edad > 40)
                                hombresMayores40++;
                        }

                        MessageBox.Show("Datos registrados correctamente.",
                                        "Registro",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        txtGenero.Clear();
                        txtEdad.Clear();
                        txtGenero.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una edad válida y positiva.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El género debe ser 1 (Mujer), 2 (Hombre) o 0 (Finalizar).",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El género debe ser un número entero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (totalHombres == 0 && totalMujeres == 0)
            {
                txtResultados.Text = "No se registraron datos.";
                return;
            }

            double porcentajeHombresMayores40 = (totalHombres > 0) ? ((double)hombresMayores40 / totalHombres) * 100 : 0;
            double porcentajeMujeres18y25 = (totalMujeres > 0) ? ((double)mujeresEntre18y25 / totalMujeres) * 100 : 0;

            txtResultados.Text = "Estadísticas de Accidentes:\n\n" +
                                 $"Total hombres: {totalHombres}\n" +
                                 $"Total mujeres: {totalMujeres}\n" +
                                 $"% Hombres mayores de 40: {porcentajeHombresMayores40:F2}%\n" +
                                 $"% Mujeres entre 18 y 25: {porcentajeMujeres18y25:F2}%";
        }
    
        private void txtGenero_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
        }
    }
}


