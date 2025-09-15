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
    public partial class Problema6 : Form
    {
        public Problema6()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
            int[] votos = new int[4];

            for (int i = 0; i < 4; i++)
            {
                string entrada = Interaction.InputBox($"Ingrese los votos del candidato #{i + 1}:","Votos", "0");
                                                      

                if (int.TryParse(entrada, out int numVotos))
                {
                    votos[i] = numVotos;
                }
                else
                {
                    MessageBox.Show("Valor inválido, se usará 0 votos.");
                    votos[i] = 0;
                }
            }

            int max = votos[0], min = votos[0];
            int indiceMax = 0, indiceMin = 0;

            for (int i = 1; i < 4; i++)
            {
                if (votos[i] > max)
                {
                    max = votos[i];
                    indiceMax = i;
                }
                if (votos[i] < min)
                {
                    min = votos[i];
                    indiceMin = i;
                }
            }
            txtGanador.Text = $"El candidato #{indiceMax + 1} tiene la mayor cantidad de votos: {max}";
            txtMenor.Text = $"El candidato #{indiceMin + 1} tiene la menor cantidad de votos: {min}";
            
        }
    }
}
