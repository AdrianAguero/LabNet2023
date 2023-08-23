namespace ManejoExepciones.Vista
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDividirPorCero = new System.Windows.Forms.Button();
            this.txtDividirPorCero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExepcion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExepcionPersonalizada = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDividirPorCero);
            this.groupBox1.Controls.Add(this.txtDividirPorCero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Division por cero";
            // 
            // btnDividirPorCero
            // 
            this.btnDividirPorCero.Location = new System.Drawing.Point(78, 128);
            this.btnDividirPorCero.Name = "btnDividirPorCero";
            this.btnDividirPorCero.Size = new System.Drawing.Size(75, 23);
            this.btnDividirPorCero.TabIndex = 2;
            this.btnDividirPorCero.Text = "Ejecutar";
            this.btnDividirPorCero.UseVisualStyleBackColor = true;
            this.btnDividirPorCero.Click += new System.EventHandler(this.btnDividirPorCero_Click);
            // 
            // txtDividirPorCero
            // 
            this.txtDividirPorCero.Location = new System.Drawing.Point(59, 78);
            this.txtDividirPorCero.Name = "txtDividirPorCero";
            this.txtDividirPorCero.Size = new System.Drawing.Size(114, 22);
            this.txtDividirPorCero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDividir);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDivisor);
            this.groupBox2.Controls.Add(this.txtDividendo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(245, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Division";
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(73, 128);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 3;
            this.btnDividir.Text = "Ejecutar";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "/";
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(130, 78);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(61, 22);
            this.txtDivisor.TabIndex = 5;
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(36, 78);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(61, 22);
            this.txtDividendo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Divisor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dividendo ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExepcion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 172);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exepcion";
            // 
            // btnExepcion
            // 
            this.btnExepcion.Location = new System.Drawing.Point(59, 107);
            this.btnExepcion.Name = "btnExepcion";
            this.btnExepcion.Size = new System.Drawing.Size(75, 23);
            this.btnExepcion.TabIndex = 7;
            this.btnExepcion.Text = "Ejecutar";
            this.btnExepcion.UseVisualStyleBackColor = true;
            this.btnExepcion.Click += new System.EventHandler(this.btnExepcion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ejecutar Exepcion del sistema";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExepcionPersonalizada);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(245, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 172);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exepcion Personalizada";
            // 
            // btnExepcionPersonalizada
            // 
            this.btnExepcionPersonalizada.Location = new System.Drawing.Point(73, 107);
            this.btnExepcionPersonalizada.Name = "btnExepcionPersonalizada";
            this.btnExepcionPersonalizada.Size = new System.Drawing.Size(75, 23);
            this.btnExepcionPersonalizada.TabIndex = 8;
            this.btnExepcionPersonalizada.Text = "Ejecutar";
            this.btnExepcionPersonalizada.UseVisualStyleBackColor = true;
            this.btnExepcionPersonalizada.Click += new System.EventHandler(this.btnExepcionPersonalizada_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ejecutar Exepcion Personalizada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 395);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDividirPorCero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.Button btnDividirPorCero;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnExepcion;
        private System.Windows.Forms.Button btnExepcionPersonalizada;
    }
}