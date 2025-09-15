namespace Laboratorio_2
{
    partial class Problema6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblC1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtGanador = new System.Windows.Forms.TextBox();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblMenir = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblVotos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.BackColor = System.Drawing.Color.Transparent;
            this.lblC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC1.Location = new System.Drawing.Point(26, 66);
            this.lblC1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(0, 18);
            this.lblC1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(91, 67);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(82, 34);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Iniciar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtGanador
            // 
            this.txtGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanador.Location = new System.Drawing.Point(31, 46);
            this.txtGanador.Margin = new System.Windows.Forms.Padding(2);
            this.txtGanador.Multiline = true;
            this.txtGanador.Name = "txtGanador";
            this.txtGanador.ReadOnly = true;
            this.txtGanador.Size = new System.Drawing.Size(214, 70);
            this.txtGanador.TabIndex = 10;
            // 
            // txtMenor
            // 
            this.txtMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenor.Location = new System.Drawing.Point(31, 179);
            this.txtMenor.Margin = new System.Windows.Forms.Padding(2);
            this.txtMenor.Multiline = true;
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.ReadOnly = true;
            this.txtMenor.Size = new System.Drawing.Size(214, 79);
            this.txtMenor.TabIndex = 11;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl1.Controls.Add(this.lblVotos);
            this.pnl1.Controls.Add(this.btnEnviar);
            this.pnl1.Controls.Add(this.lblC1);
            this.pnl1.Location = new System.Drawing.Point(40, 39);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(273, 163);
            this.pnl1.TabIndex = 12;
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.BackColor = System.Drawing.Color.Transparent;
            this.lblMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor.Location = new System.Drawing.Point(41, 25);
            this.lblMayor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(181, 18);
            this.lblMayor.TabIndex = 10;
            this.lblMayor.Text = "Mayor votos y ganador";
            // 
            // lblMenir
            // 
            this.lblMenir.AutoSize = true;
            this.lblMenir.BackColor = System.Drawing.Color.Transparent;
            this.lblMenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenir.Location = new System.Drawing.Point(37, 145);
            this.lblMenir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenir.Name = "lblMenir";
            this.lblMenir.Size = new System.Drawing.Size(194, 18);
            this.lblMenir.TabIndex = 13;
            this.lblMenir.Text = "Menor cantidad de votos";
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.SlateBlue;
            this.pnl2.Controls.Add(this.lblMenir);
            this.pnl2.Controls.Add(this.lblMayor);
            this.pnl2.Controls.Add(this.txtMenor);
            this.pnl2.Controls.Add(this.txtGanador);
            this.pnl2.Location = new System.Drawing.Point(312, 39);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(270, 315);
            this.pnl2.TabIndex = 14;
            // 
            // lblVotos
            // 
            this.lblVotos.AutoSize = true;
            this.lblVotos.BackColor = System.Drawing.Color.Transparent;
            this.lblVotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVotos.Location = new System.Drawing.Point(25, 23);
            this.lblVotos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVotos.Name = "lblVotos";
            this.lblVotos.Size = new System.Drawing.Size(236, 20);
            this.lblVotos.TabIndex = 10;
            this.lblVotos.Text = "Ingrese la cantidad de votos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(177, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(284, 20);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Candidato a Alcalde de Cartagena";
            // 
            // Problema6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Problema6";
            this.Text = "Problema6";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtGanador;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblMenir;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lblVotos;
        private System.Windows.Forms.Label lblTitulo;
    }
}