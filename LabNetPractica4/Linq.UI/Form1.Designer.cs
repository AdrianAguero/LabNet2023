namespace Linq.UI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbOpciones = new System.Windows.Forms.ComboBox();
            this.btnOption = new System.Windows.Forms.Button();
            this.lstGenerica = new System.Windows.Forms.ListBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cmbOpciones.Location = new System.Drawing.Point(12, 35);
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(406, 24);
            this.cmbOpciones.TabIndex = 0;
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(441, 31);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(217, 31);
            this.btnOption.TabIndex = 1;
            this.btnOption.Text = "Ejecutar";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // lstGenerica
            // 
            this.lstGenerica.FormattingEnabled = true;
            this.lstGenerica.ItemHeight = 16;
            this.lstGenerica.Location = new System.Drawing.Point(12, 77);
            this.lstGenerica.Name = "lstGenerica";
            this.lstGenerica.Size = new System.Drawing.Size(646, 244);
            this.lstGenerica.TabIndex = 2;
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(12, 326);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(44, 16);
            this.lblMostrar.TabIndex = 3;
            this.lblMostrar.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 351);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.lstGenerica);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.cmbOpciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOpciones;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.ListBox lstGenerica;
        private System.Windows.Forms.Label lblMostrar;
    }
}

