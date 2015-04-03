using Operaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadisticas.Vistas
{
    public partial class frmNuevaRonda : Form
    {

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public frmNuevaRonda()
        {
            InitializeComponent();
            dtpFecha.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            // Muestra la fecha como "26 Feb 2001".
            dtpFecha.CustomFormat = "dd MMM yyyy";
        }

        #endregion

        #region Métodos privados

        /// <summary>
        /// Método para guardar una nueva ronda.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Guarda los datos en la BBDD.</param>
        private void tool_Save_Click(object sender, EventArgs e)
        {
            //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
            GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql
            if (g.BuscarRonda(txtRonda.Text))
                g.NuevaRonda(txtRonda.Text, dtpFecha.Value);
            else
                MessageBox.Show("Ya existe una ronda con ese nombre.", "Nombre duplicado",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        /// <summary>
        /// Método para deshacer los cambios que se hallan hecho.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Borra los TextBox.</param>
        private void tool_Discard_Click(object sender, EventArgs e)
        {
            txtRonda.Text = string.Empty;
            dtpFecha.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        /// <summary>
        /// Método para mostrar la ayuda.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Muestra la ayuda.</param>
        private void tool_Ayuda_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
