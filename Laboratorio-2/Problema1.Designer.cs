namespace Laboratorio_2
{
    partial class Problema1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlS = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMe500 = new System.Windows.Forms.TextBox();
            this.txtMe1000 = new System.Windows.Forms.TextBox();
            this.txtMa1000 = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.lblCantidadV = new System.Windows.Forms.Label();
            this.txtCantidadVentas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlS.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(289, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(199, 24);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sumatoria de ventas";
            // 
            // pnlS
            // 
            this.pnlS.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlS.Controls.Add(this.btnEnviar);
            this.pnlS.Controls.Add(this.lstVentas);
            this.pnlS.Controls.Add(this.lblCantidadV);
            this.pnlS.Controls.Add(this.txtCantidadVentas);
            this.pnlS.Location = new System.Drawing.Point(49, 97);
            this.pnlS.Name = "pnlS";
            this.pnlS.Size = new System.Drawing.Size(439, 279);
            this.pnlS.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(60, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Menor o igual a 500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(51, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Menor o igual a 1000";
            // 
            // txtMe500
            // 
            this.txtMe500.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMe500.Location = new System.Drawing.Point(85, 210);
            this.txtMe500.Multiline = true;
            this.txtMe500.Name = "txtMe500";
            this.txtMe500.ReadOnly = true;
            this.txtMe500.Size = new System.Drawing.Size(100, 28);
            this.txtMe500.TabIndex = 6;
            // 
            // txtMe1000
            // 
            this.txtMe1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMe1000.Location = new System.Drawing.Point(85, 130);
            this.txtMe1000.Multiline = true;
            this.txtMe1000.Name = "txtMe1000";
            this.txtMe1000.ReadOnly = true;
            this.txtMe1000.Size = new System.Drawing.Size(100, 28);
            this.txtMe1000.TabIndex = 5;
            // 
            // txtMa1000
            // 
            this.txtMa1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa1000.Location = new System.Drawing.Point(85, 58);
            this.txtMa1000.Multiline = true;
            this.txtMa1000.Name = "txtMa1000";
            this.txtMa1000.ReadOnly = true;
            this.txtMa1000.Size = new System.Drawing.Size(100, 28);
            this.txtMa1000.TabIndex = 4;
            this.txtMa1000.TextChanged += new System.EventHandler(this.txtMa1000_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(295, 89);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(94, 43);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lstVentas
            // 
            this.lstVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.ItemHeight = 16;
            this.lstVentas.Location = new System.Drawing.Point(27, 59);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(239, 180);
            this.lstVentas.TabIndex = 2;
            // 
            // lblCantidadV
            // 
            this.lblCantidadV.AutoSize = true;
            this.lblCantidadV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantidadV.Location = new System.Drawing.Point(40, 31);
            this.lblCantidadV.Name = "lblCantidadV";
            this.lblCantidadV.Size = new System.Drawing.Size(226, 18);
            this.lblCantidadV.TabIndex = 2;
            this.lblCantidadV.Text = "Ingrese la cantidad de ventas";
            // 
            // txtCantidadVentas
            // 
            this.txtCantidadVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadVentas.Location = new System.Drawing.Point(289, 28);
            this.txtCantidadVentas.Multiline = true;
            this.txtCantidadVentas.Name = "txtCantidadVentas";
            this.txtCantidadVentas.Size = new System.Drawing.Size(100, 28);
            this.txtCantidadVentas.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(82, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mayor a 1000";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.txtMe500);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMe1000);
            this.panel1.Controls.Add(this.txtMa1000);
            this.panel1.Location = new System.Drawing.Point(494, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 278);
            this.panel1.TabIndex = 10;
            // 
            // Problema1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlS);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Problema1";
            this.Text = "Problema1";
            this.pnlS.ResumeLayout(false);
            this.pnlS.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMe500;
        private System.Windows.Forms.TextBox txtMe1000;
        private System.Windows.Forms.TextBox txtMa1000;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListBox lstVentas;
        private System.Windows.Forms.Label lblCantidadV;
        private System.Windows.Forms.TextBox txtCantidadVentas;
        private System.Windows.Forms.Panel panel1;
    }
}