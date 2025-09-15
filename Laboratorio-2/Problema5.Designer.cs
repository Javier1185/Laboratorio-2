namespace Laboratorio_2
{
    partial class Problema5
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
            this.lblUlam = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.Label();
            this.lstUlam = new System.Windows.Forms.ListBox();
            this.lblR = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUlam
            // 
            this.lblUlam.AutoSize = true;
            this.lblUlam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUlam.Location = new System.Drawing.Point(306, 36);
            this.lblUlam.Name = "lblUlam";
            this.lblUlam.Size = new System.Drawing.Size(207, 25);
            this.lblUlam.TabIndex = 0;
            this.lblUlam.Text = "Conjetura de Ulam";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(238, 38);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 36);
            this.txtNum.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(129, 71);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(103, 55);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(2, 42);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(230, 24);
            this.lblN.TabIndex = 3;
            this.lblN.Text = "Ingrese un número entero";
            // 
            // lstUlam
            // 
            this.lstUlam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUlam.FormattingEnabled = true;
            this.lstUlam.ItemHeight = 18;
            this.lstUlam.Location = new System.Drawing.Point(36, 53);
            this.lstUlam.Name = "lstUlam";
            this.lstUlam.Size = new System.Drawing.Size(217, 220);
            this.lstUlam.TabIndex = 4;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(98, 10);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(94, 24);
            this.lblR.TabIndex = 5;
            this.lblR.Text = "Resultado";
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnl1.Controls.Add(this.lblR);
            this.pnl1.Controls.Add(this.lstUlam);
            this.pnl1.Location = new System.Drawing.Point(458, 100);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(284, 316);
            this.pnl1.TabIndex = 6;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnl2.Controls.Add(this.lblN);
            this.pnl2.Controls.Add(this.txtNum);
            this.pnl2.Location = new System.Drawing.Point(84, 100);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(373, 104);
            this.pnl2.TabIndex = 7;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.Teal;
            this.pnl3.Controls.Add(this.btnEnviar);
            this.pnl3.Location = new System.Drawing.Point(84, 207);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(373, 209);
            this.pnl3.TabIndex = 8;
            // 
            // Problema5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lblUlam);
            this.Name = "Problema5";
            this.Text = "Problema5";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUlam;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.ListBox lstUlam;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl3;
    }
}