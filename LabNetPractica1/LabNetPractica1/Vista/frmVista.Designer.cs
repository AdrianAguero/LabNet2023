namespace LabNetPractica1.Vista
{
    partial class frmVista
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
            this.cbxTipoTransporte = new System.Windows.Forms.ComboBox();
            this.txtCantidadPasajeros = new System.Windows.Forms.TextBox();
            this.lblTipoTransporte = new System.Windows.Forms.Label();
            this.lblCantidadPasajeros = new System.Windows.Forms.Label();
            this.groupBoxTransporte = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dgvTipoTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidadPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTransporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTipoTransporte
            // 
            this.cbxTipoTransporte.FormattingEnabled = true;
            this.cbxTipoTransporte.Items.AddRange(new object[] {
            "Omnibus",
            "Taxi"});
            this.cbxTipoTransporte.Location = new System.Drawing.Point(6, 65);
            this.cbxTipoTransporte.Name = "cbxTipoTransporte";
            this.cbxTipoTransporte.Size = new System.Drawing.Size(176, 24);
            this.cbxTipoTransporte.TabIndex = 0;
            // 
            // txtCantidadPasajeros
            // 
            this.txtCantidadPasajeros.Location = new System.Drawing.Point(221, 65);
            this.txtCantidadPasajeros.Name = "txtCantidadPasajeros";
            this.txtCantidadPasajeros.Size = new System.Drawing.Size(188, 22);
            this.txtCantidadPasajeros.TabIndex = 1;
            // 
            // lblTipoTransporte
            // 
            this.lblTipoTransporte.AutoSize = true;
            this.lblTipoTransporte.Location = new System.Drawing.Point(6, 36);
            this.lblTipoTransporte.Name = "lblTipoTransporte";
            this.lblTipoTransporte.Size = new System.Drawing.Size(123, 16);
            this.lblTipoTransporte.TabIndex = 2;
            this.lblTipoTransporte.Text = "Tipo de Transporte";
            // 
            // lblCantidadPasajeros
            // 
            this.lblCantidadPasajeros.AutoSize = true;
            this.lblCantidadPasajeros.Location = new System.Drawing.Point(218, 36);
            this.lblCantidadPasajeros.Name = "lblCantidadPasajeros";
            this.lblCantidadPasajeros.Size = new System.Drawing.Size(145, 16);
            this.lblCantidadPasajeros.TabIndex = 3;
            this.lblCantidadPasajeros.Text = "Cantidad de Pasajeros";
            // 
            // groupBoxTransporte
            // 
            this.groupBoxTransporte.Controls.Add(this.lblMensaje);
            this.groupBoxTransporte.Controls.Add(this.lblMensajes);
            this.groupBoxTransporte.Controls.Add(this.btnAgregar);
            this.groupBoxTransporte.Controls.Add(this.lblTipoTransporte);
            this.groupBoxTransporte.Controls.Add(this.lblCantidadPasajeros);
            this.groupBoxTransporte.Controls.Add(this.cbxTipoTransporte);
            this.groupBoxTransporte.Controls.Add(this.txtCantidadPasajeros);
            this.groupBoxTransporte.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTransporte.Name = "groupBoxTransporte";
            this.groupBoxTransporte.Size = new System.Drawing.Size(460, 265);
            this.groupBoxTransporte.TabIndex = 4;
            this.groupBoxTransporte.TabStop = false;
            this.groupBoxTransporte.Text = "Transporte";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(6, 196);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(10, 16);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = ".";
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Location = new System.Drawing.Point(6, 170);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(0, 16);
            this.lblMensajes.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(347, 196);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 45);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTipoTransporte,
            this.dgvCantidadPasajeros});
            this.dataGridView.Location = new System.Drawing.Point(12, 300);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(460, 208);
            this.dataGridView.TabIndex = 5;
            // 
            // dgvTipoTransporte
            // 
            this.dgvTipoTransporte.HeaderText = "Transporte";
            this.dgvTipoTransporte.MinimumWidth = 6;
            this.dgvTipoTransporte.Name = "dgvTipoTransporte";
            this.dgvTipoTransporte.Width = 125;
            // 
            // dgvCantidadPasajeros
            // 
            this.dgvCantidadPasajeros.HeaderText = "Cantidad de Pasajeros";
            this.dgvCantidadPasajeros.MinimumWidth = 6;
            this.dgvCantidadPasajeros.Name = "dgvCantidadPasajeros";
            this.dgvCantidadPasajeros.Width = 125;
            // 
            // frmVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 520);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBoxTransporte);
            this.Name = "frmVista";
            this.Text = "frmVista";
            this.groupBoxTransporte.ResumeLayout(false);
            this.groupBoxTransporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipoTransporte;
        private System.Windows.Forms.TextBox txtCantidadPasajeros;
        private System.Windows.Forms.Label lblTipoTransporte;
        private System.Windows.Forms.Label lblCantidadPasajeros;
        private System.Windows.Forms.GroupBox groupBoxTransporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTipoTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidadPasajeros;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.Label lblMensaje;
    }
}