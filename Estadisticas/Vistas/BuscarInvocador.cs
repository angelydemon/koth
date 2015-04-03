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
    public partial class frmBuscarInvocador : Form
    {

        #region Variables

        private bool invocador = false;
        private bool estadistica = false;

        #endregion

        #region Propiedades

        public bool Invocador
        {
            get { return invocador; }
            set { invocador = value; }
        }

        public bool Estadistica
        {
            get { return estadistica; }
            set { estadistica = value; }
        }

        #endregion

        public frmBuscarInvocador()
        {
            InitializeComponent();            
        }
        
        #region Eventos

        /// <summary>
        /// Evento de carga del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBuscarInvocador_Load(object sender, EventArgs e)
        {
            CargarInvocador();
            toolStrip_EditInvocador.Visible = false;
            toolStrip_DeleteInvocador.Visible = false;
            toolStrip_DeleteEsta.Visible = false;
            toolStrip_EditEsta.Visible = false;
            grbDatos.Visible = false;
            grbEstadisticas.Visible = false;
        }

        /// <summary>
        /// Evento que llama al método para eliminar un invocadro.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void toolStrip_Delete_Click(object sender, EventArgs e)
        {
            EliminarInvocador();
        }

        /// <summary>
        /// Evento que llama al método para editar un invocador.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void toolStrip_Edit_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                ActualizarDatosInvocador();
                MostrarDatos();
                this.Close();
            }
        }        

        /// <summary>
        /// Evento que llama al método mostrar datos de invocador.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void toolStrip_Search_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método que llena de datos elcombo de invocador. 
        /// </summary>
        private void CargarInvocador()
        {
            DataTable invocador = new DataTable();
            //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
            GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            try
            {
                invocador = g.CargarInvocador();

                // Se añade una row vacía al combo para que se muestre vacio al inicio.
                DataRow row = invocador.NewRow();
                row["INVOCADOR_NOMBRE"] = "";
                row["INVOCADOR_ID"] = 0;
                invocador.Rows.InsertAt(row, 0);

                cboInvocador.DisplayMember = "INVOCADOR_NOMBRE";
                cboInvocador.ValueMember = "INVOCADOR_ID";
                cboInvocador.DataSource = invocador;

                // Autocompletado.
                foreach (DataRow r in invocador.Rows)
                {
                    stringCol.Add(Convert.ToString(r["INVOCADOR_NOMBRE"]));
                }

                cboInvocador.AutoCompleteCustomSource = stringCol;
                cboInvocador.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboInvocador.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Método que muestra los datos del invocador seleccionado en el combo box.
        /// </summary>
        private void MostrarDatos()
        {

            //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
            GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql
            List<Invocador> lista = new List<Invocador>();
            List<Clasificacion> listaClasi = new List<Clasificacion>();

            // Si viene de buscar estadísticas activa unos controles.
            if (Estadistica)
            {
                toolStrip_EditEsta.Visible = true;
                toolStrip_DeleteEsta.Visible = true;
                grbEstadisticas.Visible = true;
                listaClasi = g.CargarClasificacionJugador(Convert.ToInt32(cboInvocador.SelectedValue.ToString()));
                if (listaClasi.Count == 0)
                    MessageBox.Show("No se ha encontrado ningún invocador.");
                else
                {
                    txtNombreEsta.Text = listaClasi[0].Invocador.ToString();
                    txtKills.Text = listaClasi[0].Kills.ToString();
                    txtDefeats.Text = listaClasi[0].Defeats.ToString();
                    txtAssists.Text = listaClasi[0].Assists.ToString();
                    txtGold.Text = listaClasi[0].Gold.ToString();
                    txtMinions.Text = listaClasi[0].Minions.ToString();
                    txtMiniNeutral.Text = listaClasi[0].MiniNeutral.ToString();
                    txtKDA.Text = listaClasi[0].Kda.ToString();
                }

            }
            // Si viene de buscar invocador activa otros controles.
            else if (Invocador)
            {
                toolStrip_EditInvocador.Visible = true;
                toolStrip_DeleteInvocador.Visible = true;
                grbDatos.Visible = true;
                lista = g.CargarDatosInvocador(cboInvocador.SelectedValue.ToString());
                if (lista.Count == 0)
                    MessageBox.Show("No se ha encontrado ningún invocador.");
                else
                {
                    txtNombre.Text = lista[0].NombreInvocador.ToString();
                    txtEmail.Text = lista[0].EmailInvocador.ToString();
                }
            }
            
        }    

        /// <summary>
        /// Método que elimina un invocador.
        /// </summary>
        private void EliminarInvocador()
        {
            //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
            GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql
            if (MessageBox.Show(Resources.QUESTION_ELIMINAR_INVOCADOR,
                                Resources.QUESTION_ELIMINAR_INVOCADOR_TITULO,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                g.EliminarInvocador(cboInvocador.SelectedValue.ToString());
                g.EliminarEstadisitcas(cboInvocador.SelectedValue.ToString());
                this.Close();
            }
        }        

        /// <summary>
        /// Método que actualiza los datos de un invocador.
        /// </summary>
        private void ActualizarDatosInvocador()
        {
            //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
            GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql
            int id = Convert.ToInt32(cboInvocador.SelectedValue.ToString());
            g.ActualizarDatosInvocador(id, txtNombre.Text, txtEmail.Text);
        }

        /// <summary>
        /// Vaida los campos obligatorios.
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            bool validar = true;

            if (txtNombre.Text == string.Empty)
            {
                errorProvider.SetError(txtNombre, Resources.ERROR_NOMBRE_OBLIGATORIO);
                validar = false;
            }

            return validar;
        }

        #endregion

    }
}
