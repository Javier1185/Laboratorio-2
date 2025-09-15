using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Laboratorio_2
{
    public partial class Problema3 : Form
    {

        public Problema3()
        {
            InitializeComponent();
        }

        int totalHombres = 0;
        int totalMujeres = 0;
        int hombresMayores40 = 0;
        int mujeres1825 = 0;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int genero = int.Parse(txtgenero.Text);
                int edad = int.Parse(txtedad.Text);

                if (genero == 1) // mujer
                {
                    totalMujeres++;
                    if (edad >= 18 && edad <= 25)
                    {
                        mujeres1825++;
                    }
                }
                else if (genero == 2) // hombre
                {
                    totalHombres++;
                    if (edad > 40)
                    {
                        hombresMayores40++;
                    }
                }
                else if (genero == 0)
                {
                    MessageBox.Show("⚠ Si desea terminar, use el botón Finalizar.");
                }
                else
                {
                    MessageBox.Show("⚠ Género inválido. Use 1=Mujer, 2=Hombre.");
                }

                // Limpiar para el siguiente ingreso
                txtgenero.Clear();
                txtedad.Clear();
                txtgenero.Focus();
            }
            catch
            {
                MessageBox.Show("⚠ Ingrese solo números válidos.");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int totalConductores = totalHombres + totalMujeres;
            double porcentajeHombres40 = 0;
            double porcentajeMujeres1825 = 0;

            if (totalConductores > 0)
            {
                porcentajeHombres40 = (hombresMayores40 * 100.0) / totalConductores;
                porcentajeMujeres1825 = (mujeres1825 * 100.0) / totalConductores;
            }

           btncalcular.Text = "=== Resultados ===\n" +
                                 $"Total de hombres: {totalHombres}\n" +
                                 $"Total de mujeres: {totalMujeres}\n" +
                                 $"% Hombres > 40 años: {porcentajeHombres40:F2}%\n" +
                                 $"% Mujeres 18–25 años: {porcentajeMujeres1825:F2}%";
        }
    }
}
   

