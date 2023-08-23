using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoExepciones.Vista
{
    public partial class Form1 : Form
    {
        Logic instanciaLogic = new Logic();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDividirPorCero_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtDividirPorCero.Text);
                a.DividirPorCero();
            }

            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception)
            {
                MessageBox.Show("Porfavor ingresar un numero");
            }

            finally { MessageBox.Show("Operacion finalizada"); }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                decimal resultadoDeDivision = Logic.Dividir(Convert.ToInt32(txtDividendo.Text), Convert.ToInt32(txtDivisor.Text));
                MessageBox.Show(resultadoDeDivision.ToString());
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show($"Solo chuck Norris divide por 0! ({ex.Message})");
            }

            catch (Exception)
            {
                MessageBox.Show("Seguro ingreso una letra o no ingreso nada!");
            }
        }

        private void btnExepcion_Click(object sender, EventArgs e)
        {
            try
            {
                instanciaLogic.ExepcionPunto3();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, de tipo: {ex.GetType()}");
            }
        }

        private void btnExepcionPersonalizada_Click(object sender, EventArgs e)
        {
            try
            {
                instanciaLogic.ExepcionPersonalizadaPunto4();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, de tipo: {ex.GetType()}");
            }
        }
    }
}
