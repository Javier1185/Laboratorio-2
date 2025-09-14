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
    public partial class Problema5 : Form
    {
        public Problema5()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int num = 0;
            int[] a;
            lstUlam.Items.Clear();

            num = Convert.ToInt32(txtNum.Text);
         
            while (num != 1) {

                if (num % 2 == 0)
                {

                    num = num / 2;
                    lstUlam.Items.Add(num);

                }
                else {
                    num = (num * 3) + 1;
                    lstUlam.Items.Add(num);
                }



            }
           
        }
    }
}
