using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_promedio.Frm
{
    //---------------------------------------------------------------------
    //@Autor: Aarón Flores Pasos.
    //Fecha: 22/02/2023
    //Descripción: Clase secundaria al iniciar el programa.
    //---------------------------------------------------------------------
    public partial class FrmWorker : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public FrmWorker()
        {
            InitializeComponent();
        }

        #region Métodos de la ventana.
        //---------------------------------------------------------------------
        //Método (botón) para acabar la ejecución.
        //---------------------------------------------------------------------
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //---------------------------------------------------------------------
        //Método (botón) para minimizar la ventana.
        //---------------------------------------------------------------------
        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Métodos de las operaciones.
        //---------------------------------------------------------------------
        //Método (botón) para promediar la ganancia.
        //---------------------------------------------------------------------
        private void BtnAverage_Click(object sender, EventArgs e)
        {
            double Hours, Rate;

            while (!double.TryParse(TxtHours.Text, out Hours))
            {
                MessageBox.Show($"Entrada inválida : {TxtHours.Text} en {TxtHours.Name}, por favor ingrese un número.");
                break;
            }

            while (!double.TryParse(TxtRate.Text, out Rate))
            {
                MessageBox.Show($"Entrada inválida : {TxtRate.Text} en {TxtRate.Name}, por favor ingrese un número.");
                break;
            }

            if (Hours == 0 && Rate == 0)
            {
                TxtIncome.ForeColor = Color.Red;
                TxtIncome.Text = "Todos los valores son 0";
            }
            else
            {
                TxtIncome.ForeColor = Color.Black;
                TxtIncome.Text = Income(Hours, Rate).ToString();
            }
        }

        //---------------------------------------------------------------------
        //Método para promediar la ganancia.
        //---------------------------------------------------------------------
        private double Income(double Hours, double Rate)
        {
            return Hours * Rate;
        }

        //---------------------------------------------------------------------
        //Método (botón) para resetear las cajas de texto.
        //---------------------------------------------------------------------
        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtIncome.Text = string.Empty;
            TxtHours.Text = string.Empty;
            TxtRate.Text = string.Empty;
        }

        //---------------------------------------------------------------------
        //Método (botón) para acabar la ejecución
        //---------------------------------------------------------------------
        private void BtnLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Método para regresar a la ventana principal.
        //---------------------------------------------------------------------
        //Método (botón) para abrir la ventana principal.
        //---------------------------------------------------------------------
        private void BtnNote_Click(object sender, EventArgs e)
        {
            FrmMain FrmMain = new FrmMain();
            FrmMain.Show();
            this.Hide();
        }
        #endregion
    }
}
