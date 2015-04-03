#region Librerias

using Estadisticas.Properties;
using Operaciones;
using System;
using System.Windows.Forms;


#endregion

namespace Estadisticas.Vistas
{
    public partial class frmNuevoInvocador : Form
    {
        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public frmNuevoInvocador()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento que llama a guardar invocador.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumetno del evento.</param>
        private void tool_Save_Click(object sender, EventArgs e)
        {
            
            Guardar();
        }

        /// <summary>
        /// Método que guarda un invocador.
        /// </summary>
        private void Guardar()
        {
            if (Validar())
            {
                //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
                GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql

                if (g.BuscarInvocador(txtNombreInvocador.Text))
                {
                    g.AltaInvocador(txtNombreInvocador.Text, txtEmail.Text);
                    g.AltaClasificacion(txtNombreInvocador.Text);
                    Close();
                }
                else
                    MessageBox.Show("Ya existe un invocador con ese nombre.", "Nombre duplicado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        /// <summary>
        /// Método para deshacer los cambios que se hallan hecho.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Borra los TextBox.</param>
        private void tool_Discard_Click(object sender, EventArgs e)
        {
            txtNombreInvocador.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        /// <summary>
        /// Método para mostrar la ayuda.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Muestra la ayuda.</param>
        private void tool_Ayuda_Click(object sender, EventArgs e)
        {
            //TODO
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Valida los campos obligatorios.
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            bool validar = true;

            if (txtNombreInvocador.Text == string.Empty)
            {
                errorProvider.SetError(txtNombreInvocador, Resources.ERROR_NOMBRE_OBLIGATORIO);
                validar = false;
            }

            return validar;
        }

        #endregion
        
    }
}
