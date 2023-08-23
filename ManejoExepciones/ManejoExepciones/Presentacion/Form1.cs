using System;
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
                MessageBox.Show("PORFAVOR INGRESAR UN NUMERO!");
            }

            finally { MessageBox.Show("Operacion finalizada"); }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                decimal resultadoDeDivision = Logic.Dividir(Convert.ToDecimal(txtDividendo.Text), Convert.ToDecimal(txtDivisor.Text));
                MessageBox.Show(resultadoDeDivision.ToString());
            }
            catch (DivideByZeroException ex)
            {
                
                imgChuck.Visible = true;
                imgChuck.BringToFront();
                MessageBox.Show($"error ({ex.Message})");
            }

            catch (Exception)
            {
                MessageBox.Show("PORFAVOR INGRESAR UN NUMERO!");
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
