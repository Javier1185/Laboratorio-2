namespace Laboratorio_2
{
    partial class Tranformador
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInversor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textDatos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tranformador";
            // 
            // buttonInversor
            // 
            this.buttonInversor.BackColor = System.Drawing.Color.DarkRed;
            this.buttonInversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInversor.Location = new System.Drawing.Point(296, 229);
            this.buttonInversor.Name = "buttonInversor";
            this.buttonInversor.Size = new System.Drawing.Size(186, 54);
            this.buttonInversor.TabIndex = 1;
            this.buttonInversor.Text = "Invertir";
            this.buttonInversor.UseVisualStyleBackColor = false;
            this.buttonInversor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese un numero entero:";
            // 
            // textDatos
            // 
            this.textDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDatos.Location = new System.Drawing.Point(445, 153);
            this.textDatos.Multiline = true;
            this.textDatos.Name = "textDatos";
            this.textDatos.Size = new System.Drawing.Size(187, 47);
            this.textDatos.TabIndex = 3;
            this.textDatos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero invertido:";
            // 
            // textResultado
            // 
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.Location = new System.Drawing.Point(383, 324);
            this.textResultado.Multiline = true;
            this.textResultado.Name = "textResultado";
            this.textResultado.ReadOnly = true;
            this.textResultado.Size = new System.Drawing.Size(157, 49);
            this.textResultado.TabIndex = 5;
            // 
            // Tranformador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonInversor);
            this.Controls.Add(this.label1);
            this.Name = "Tranformador";
            this.Text = "Problema2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInversor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textResultado;
    }
}