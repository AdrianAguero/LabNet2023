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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxTipoTransporte = new System.Windows.Forms.ComboBox();
            this.txtCantidadPasajeros = new System.Windows.Forms.TextBox();
            this.lblTipoTransporte = new System.Windows.Forms.Label();
            this.lblCantidadPasajeros = new System.Windows.Forms.Label();
            this.groupBoxTransporte = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxVelociad = new System.Windows.Forms.GroupBox();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnFrenar = new System.Windows.Forms.Button();
            this.dgvTipoTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidadPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.groupBoxTransporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxVelociad.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxTipoTransporte
            // 
            this.cbxTipoTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoTransporte.FormattingEnabled = true;
            this.cbxTipoTransporte.Items.AddRange(new object[] {
            "Omnibus",
            "Taxi"});
            this.cbxTipoTransporte.Location = new System.Drawing.Point(6, 65);
            this.cbxTipoTransporte.Name = "cbxTipoTransporte";
            this.cbxTipoTransporte.Size = new System.Drawing.Size(251, 24);
            this.cbxTipoTransporte.TabIndex = 0;
            // 
            // txtCantidadPasajeros
            // 
            this.txtCantidadPasajeros.Location = new System.Drawing.Point(6, 145);
            this.txtCantidadPasajeros.Name = "txtCantidadPasajeros";
            this.txtCantidadPasajeros.Size = new System.Drawing.Size(251, 22);
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
            this.lblCantidadPasajeros.Location = new System.Drawing.Point(3, 116);
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
            this.groupBoxTransporte.Size = new System.Drawing.Size(309, 319);
            this.groupBoxTransporte.TabIndex = 4;
            this.groupBoxTransporte.TabStop = false;
            this.groupBoxTransporte.Text = "Transporte";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(6, 196);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 20);
            this.lblMensaje.TabIndex = 6;
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
            this.btnAgregar.Location = new System.Drawing.Point(113, 264);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 45);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTipoTransporte,
            this.dgvCantidadPasajeros});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.Azure;
            this.dataGridView.Location = new System.Drawing.Point(327, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(518, 315);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // groupBoxVelociad
            // 
            this.groupBoxVelociad.Controls.Add(this.lblVelocidad);
            this.groupBoxVelociad.Controls.Add(this.btnAcelerar);
            this.groupBoxVelociad.Controls.Add(this.btnFrenar);
            this.groupBoxVelociad.Location = new System.Drawing.Point(845, 12);
            this.groupBoxVelociad.Name = "groupBoxVelociad";
            this.groupBoxVelociad.Size = new System.Drawing.Size(349, 319);
            this.groupBoxVelociad.TabIndex = 6;
            this.groupBoxVelociad.TabStop = false;
            this.groupBoxVelociad.Text = "seleciona el transporte";
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(190, 51);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(153, 50);
            this.btnAcelerar.TabIndex = 1;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // btnFrenar
            // 
            this.btnFrenar.Location = new System.Drawing.Point(6, 51);
            this.btnFrenar.Name = "btnFrenar";
            this.btnFrenar.Size = new System.Drawing.Size(153, 50);
            this.btnFrenar.TabIndex = 0;
            this.btnFrenar.Text = "Frenar";
            this.btnFrenar.UseVisualStyleBackColor = true;
            this.btnFrenar.Click += new System.EventHandler(this.btnFrenar_Click);
            // 
            // dgvTipoTransporte
            // 
            this.dgvTipoTransporte.HeaderText = "Transporte";
            this.dgvTipoTransporte.MinimumWidth = 6;
            this.dgvTipoTransporte.Name = "dgvTipoTransporte";
            // 
            // dgvCantidadPasajeros
            // 
            this.dgvCantidadPasajeros.HeaderText = "Cantidad de Pasajeros";
            this.dgvCantidadPasajeros.MinimumWidth = 6;
            this.dgvCantidadPasajeros.Name = "dgvCantidadPasajeros";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidad.ForeColor = System.Drawing.Color.Navy;
            this.lblVelocidad.Location = new System.Drawing.Point(6, 151);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(0, 20);
            this.lblVelocidad.TabIndex = 2;
            // 
            // frmVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1206, 369);
            this.Controls.Add(this.groupBoxVelociad);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBoxTransporte);
            this.Name = "frmVista";
            this.Text = "frmVista";
            this.groupBoxTransporte.ResumeLayout(false);
            this.groupBoxTransporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxVelociad.ResumeLayout(false);
            this.groupBoxVelociad.PerformLayout();
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
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.Label lblMensaje;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxVelociad;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Button btnFrenar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTipoTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidadPasajeros;
        private System.Windows.Forms.Label lblVelocidad;
    }
}