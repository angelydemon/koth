using Estadisticas.Properties;
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
    public partial class frmNuevoCampeon : Form
    {
        public frmNuevoCampeon()
        {
            InitializeComponent();
        }

        #region Eventos

        /// <summary>
        /// Evento que llama al método para guardar un nuevo campeón.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tool_Save_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        /// <summary>
        /// Evento que llama al método que descarta los cambios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tool_Discard_Click(object sender, EventArgs e)
        {
            Discard();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Evento que guarda un nuevo campeón.
        /// </summary>
        private void Guardar()
        {
            // Se validan los campos obligatorios.
            if (Validar())
            {
                //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
                GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql
                // Se busca si existe un campeón con el mismo nombre.
                if (g.BuscarCampeon(txtCampeon.Text))
                {
                    // Si no existe ningún campéón con ese nombre se inserta.
                    g.NuevoCampeon(txtCampeon.Text);
                    this.Close();
                }
                else
                    // Si ya existe un campeón con ese nombre muestra un mensaje de error.
                    MessageBox.Show("Ya existe un campeón con ese nombre.", "Nombre duplicado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Método que valida los campos obligatorios.
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            bool validar = true;

            if (txtCampeon.Text == string.Empty)
            {
                errorProvider.SetError(txtCampeon, Resources.ERROR_NOMBRECAMPEON_OBLIGATORIO);
                validar = false;
            }
                
            return validar;
        }

        /// <summary>
        /// Método que descarga los cambios.
        /// </summary>
        private void Discard()
        {
            txtCampeon.Text = string.Empty;
        }

        #endregion

        

        

    }
}
