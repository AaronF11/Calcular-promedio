using Calcular_promedio.Frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_promedio
{
    //---------------------------------------------------------------------
    //@Autor: Aarón Flores Pasos.
    //Fecha: 22/02/2023
    //Descripción: Clase principal al iniciar el programa.
    //---------------------------------------------------------------------
    public partial class FrmMain : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public FrmMain()
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
        //Método (botón) para promediar las notas.
        //---------------------------------------------------------------------
        private void BtnAverage_Click(object sender, EventArgs e)
        {
            double N1, N2, N3;

            while (!double.TryParse(TxtN1.Text, out N1))
            {
                MessageBox.Show($"Entrada inválida : {TxtN1.Text} en {TxtN1.Name}, por favor ingrese un número.");
                break;
            }

            while (!double.TryParse(TxtN2.Text, out N2))
            {
                MessageBox.Show($"Entrada inválida : {TxtN2.Text} en {TxtN2.Name}, por favor ingrese un número.");
                break;
            }

            while (!double.TryParse(TxtN3.Text, out N3))
            {
                MessageBox.Show($"Entrada inválida : {TxtN3.Text} en {TxtN3.Name}, por favor ingrese un número.");
                break;
            }

            if (N1 == 0 && N2 == 0 && N3 == 0)
            {
                TxtAverage.ForeColor = Color.Red;
                TxtAverage.Text = "Todas las notas son 0";
            }
            else
            {
                TxtAverage.ForeColor = Color.Black;
                TxtAverage.Text = Average(N1, N2, N3).ToString();
            }
        }

        //---------------------------------------------------------------------
        //Método para promediar las notas.
        //---------------------------------------------------------------------
        private double Average(double N1, double N2, double N3)
        {
            return (N1 + N2 + N3) / 3;
        }

        //---------------------------------------------------------------------
        //Método (botón) para resetear las cajas de texto.
        //---------------------------------------------------------------------
        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtAverage.Text = string.Empty;
            TxtN1.Text = string.Empty;
            TxtN2.Text = string.Empty;
            TxtN3.Text = string.Empty;
        }

        //---------------------------------------------------------------------
        //Método (botón) para acabar la ejecución
        //---------------------------------------------------------------------
        private void BtnLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Método para abrir ventana de trabajador.
        //---------------------------------------------------------------------
        //Método (botón) para abrir la ventana del trabajador.
        //---------------------------------------------------------------------
        private void BtnWorker_Click(object sender, EventArgs e)
        {
            FrmWorker FrmWorker = new FrmWorker();
            FrmWorker.Show();
            this.Hide();
        }
        #endregion
    }
}
