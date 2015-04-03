using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace Estadisticas.Vistas
{
    public partial class frmConfiguracion : Form
    {
        // Variables
        //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
        GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql

        // Constructor
        public frmConfiguracion()
        {
            InitializeComponent();            
            //txtRuta.Text = g.mostrarRuta();
        }

        /// <summary>
        /// Método que cierra el cuadro de diálogo.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Muestra la ayuda de la ventana.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
