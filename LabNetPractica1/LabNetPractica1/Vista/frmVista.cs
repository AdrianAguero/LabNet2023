using LabNetPractica1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNetPractica1.Vista
{
    public partial class frmVista : Form
    {
        private List<Transporte> listaTransportes = new List<Transporte>();
        private int contadorOmnibus = 0;
        private int contadorTaxis = 0;

        public frmVista()
        {
            InitializeComponent();
        }

        #region botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                string tipo = cbxTipoTransporte.SelectedItem.ToString();
                int cantidad = int.Parse(txtCantidadPasajeros.Text);

                Transporte transporte;

                if (tipo == "Omnibus")
                {
                    transporte = new Omnibus(cantidad);
                    contadorOmnibus++;
                }
                else
                {
                    transporte = new Taxi(cantidad);
                    contadorTaxis++;
                }

                listaTransportes.Add(transporte);
                ActualizarDataGridView();
                LimpiarCampos();
            }
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                Transporte transporte = listaTransportes[rowIndex];

                transporte.Acelerar();
                lblVelocidad.Text = $"Se ha acelerado el {transporte.GetType().Name}. \nNueva velocidad: {transporte.velocidad}";
            }
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                Transporte transporte = listaTransportes[rowIndex];

                transporte.Frenar();
                lblVelocidad.Text = $"Se ha frenado el {transporte.GetType().Name}. \nNueva velocidad: {transporte.velocidad}";
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView.Rows[e.RowIndex].Selected = true;
            }
        }
        #endregion

        #region metodos
        private void LimpiarCampos()
        {
            cbxTipoTransporte.SelectedIndex = -1;
            txtCantidadPasajeros.Clear();
        }
        private void ActualizarDataGridView()
        {
            dataGridView.Rows.Clear();

            foreach (Transporte transporte in listaTransportes)
            {
                string tipoTransporte = transporte.GetType().Name;
                int cantidadPasajeros = transporte.Pasajero;
                

                dataGridView.Rows.Add(tipoTransporte, cantidadPasajeros);
            }
        }

        #endregion

        #region validaciones 
        private bool ValidarDatos()
        {
            if (cbxTipoTransporte.SelectedItem == null || string.IsNullOrEmpty(txtCantidadPasajeros.Text))
            {
                lblMensaje.Text = "Debe seleccionar un tipo de transporte \n y especificar la cantidad de pasajeros.";
                return false;
            }

            string tipo = cbxTipoTransporte.SelectedItem.ToString();
            int cantidad;

            if (!int.TryParse(txtCantidadPasajeros.Text, out cantidad) || cantidad <= 0 )
            {
                lblMensaje.Text = "La cantidad de pasajeros debe \nser un número mayor a 0.";
                return false;
            }

            int maxPasajeros = (tipo == "Omnibus") ? 50 : 4;

            if (cantidad > maxPasajeros)
            {
                lblMensaje.Text = $"La cantidad máxima de pasajeros para\nun {tipo} es {maxPasajeros}.";
                return false;
            }

            if ((tipo == "Omnibus" && contadorOmnibus >= 5) || (tipo == "Taxi" && contadorTaxis >= 5))
            {
                lblMensaje.Text = $"No se pueden agregar más de 5 {tipo}s.";
                return false;
            }

            lblMensaje.Text = ""; 
            return true;
        }

        #endregion
       
    }
}
