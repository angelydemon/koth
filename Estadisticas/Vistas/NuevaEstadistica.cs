#region Librerias

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

#endregion

namespace Estadisticas.Vistas
{
    public partial class frmNuevaEstadistica : Form
    {
        #region Constructor

        public frmNuevaEstadistica()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento de carga del formulario.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void frmNuevaEstadistica_Load(object sender, EventArgs e)
        {
            CargarCombos();
            txtKDA.ReadOnly = true;
            ComprobarVacios();
        }

        /// <summary>
        /// Evento que llama al método para guardar los datos.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void tool_Save_Click(object sender, EventArgs e)
        {
            Guardar();            
        }        

        /// <summary>
        /// Evento que carga el combo partdia cuando se seleccionar una ronda.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void cboRonda_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPartida();
        }

        /// <summary>
        /// Evento que llama al método para calcular el KDA.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void txtAssists_TextChanged(object sender, EventArgs e)
        {
            CalculaKDA();            
        }

        /// <summary>
        /// Evento que llama a descartar cambios.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void tool_Discard_Click(object sender, EventArgs e)
        {
            DescartarCambios();
        }

        /// <summary>
        /// Solo permite ingresar numeros en el text box.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Método que gurda los datos.
        /// </summary>
        private void Guardar()
        {
            //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
            GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql
            List<Clasificacion> clasificacionAnterior = new List<Clasificacion>();
            Clasificacion clasificacionNueva = new Clasificacion();

            ComprobarVacios();
            if (ValidarCampos())
            {

                // Conversion (cuando sea preciso) de paráetros para enviar a la consulta.
                int id_invocador = Convert.ToInt32(cboInvocador.SelectedValue);
                int id_partida = Convert.ToInt32(cboPartida.SelectedValue);
                int id_ronda = Convert.ToInt32(cboRonda.SelectedValue);
                int id_campeon = Convert.ToInt32(cboCampeon.SelectedValue);
                int puntos = 0;
                double k = Convert.ToInt32(txtKills.Text);
                double d = Convert.ToInt32(txtDefeats.Text);
                double a = Convert.ToInt32(txtAssists.Text);
                double kda = Convert.ToDouble(txtKDA.Text);
                int gold = Convert.ToInt32(txtGold.Text);
                int minions = Convert.ToInt32(txtMinions.Text);
                int mini_neutral = Convert.ToInt32(txtMiniNeutral.Text);

                if (rdbWin.Checked)
                    puntos = 1;

                // Se compureba que no se repite para un jugador misma ronda y misma partida.
                if (g.ExisteRondaPartida(id_ronda, id_partida, id_invocador))
                {
                    // Si no se repite introduce nueva estadistica.
                    g.NuevaEstadistica(id_invocador, id_partida, id_ronda, id_campeon, puntos, k, d, a, kda, gold, minions, mini_neutral);

                    // Se obtienen los datos anteriores.
                    clasificacionAnterior = g.CargarClasificacionJugador(id_invocador);

                    // Se añaden valores a para la nueva clasifiación.
                    clasificacionNueva.Invocador = cboInvocador.SelectedItem.ToString();
                    clasificacionNueva.Assists = Convert.ToInt32(txtAssists.Text);
                    clasificacionNueva.Defeats = Convert.ToInt32(txtDefeats.Text);
                    clasificacionNueva.Kills = Convert.ToInt32(txtKills.Text);
                    clasificacionNueva.Kda = kda;
                    clasificacionNueva.Puntos = puntos;

                    // Y actualiza la clasificación general.
                    g.ActualizarClasificacionGeneral(clasificacionAnterior, clasificacionNueva);
                }

                // Si es la primera asistencia a la ronda se inserta en asistencia.
                if (g.ExisteRondaInvocador(id_ronda, id_invocador))
                    g.NuevaAsistencia(id_ronda, id_invocador);


                this.Close();
            }
        }

        /// <summary>
        /// Método para validar los campos obligatorios.
        /// </summary>
        /// <returns>True si pasa la validación. False si no pasa la validación.</returns>
        private bool ValidarCampos()
        {            
            bool validar = true;

            // Comprueba la ronda.
            if (cboRonda.SelectedIndex == 0)
            {
                errorProvider.SetError(cboRonda, Resources.ERROR_RONDA_OBLIGATORIA);
                validar = false;
            }

            // Comprueba la partida.
            if (cboPartida.SelectedIndex == 0)
            {
                errorProvider.SetError(cboPartida, Resources.ERROR_PARTIDA_OBLIGATORIA);
                validar = false;
            }

            // Comprueba el invocador.
            if (cboInvocador.SelectedIndex == 0)
            {
                errorProvider.SetError(cboInvocador, Resources.ERROR_INVOCADOR_OBLIGATORIO);
                validar = false;
            }

            // Comprueba win/lost
            if (!rdbWin.Checked && !rdbLost.Checked)
            {
                errorProvider.SetError(rdbWin, Resources.ERROR_WINLOST_OBLIGATORIO);
                validar = false;
            }

            return validar;
        }

        /// <summary>
        /// Método que calcula el KDA correspondiente del invocador para la partida actual.
        /// </summary>
        private void CalculaKDA()
        {
            ComprobarVacios();

            double k = Convert.ToInt32(txtKills.Text);
            double d;
            double a = Convert.ToInt32(txtAssists.Text);
            if (Convert.ToInt32(txtDefeats.Text) == 0)
                d = 1;
            else
                d = Convert.ToInt32(txtDefeats.Text);
            double kda = (k + a) / d;
            txtKDA.Text = kda.ToString();
        }

        /// <summary>
        /// Método que llama a las funciones para cargar los combo box
        /// </summary>
        public void CargarCombos()
        {
            CargarRonda();
            CargarInvocador();
            CargarCampeon();
        }

        /// <summary>
        /// Método que llena de datos el combo de rondas.
        /// </summary>
        public void CargarRonda()
        {
            DataTable ronda = new DataTable();
            //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
            GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            try
            {
                ronda = g.CargarRonda();

                // Se añade una row vacía al combo para que se muestre vacio al inicio.
                DataRow row = ronda.NewRow();
                row["RONDA_RONDA"] = "";
                row["RONDA_ID_RONDA"] = 0;
                ronda.Rows.InsertAt(row, 0);

                // Autocompletado.
                foreach (DataRow r in ronda.Rows)
                {
                    stringCol.Add(Convert.ToString(r["RONDA_RONDA"]));
                }

                cboRonda.AutoCompleteCustomSource = stringCol;
                cboRonda.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboRonda.AutoCompleteSource = AutoCompleteSource.CustomSource;

                cboRonda.DisplayMember = "RONDA_RONDA";
                cboRonda.ValueMember = "RONDA_ID_RONDA";
                cboRonda.DataSource = ronda;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Método que llena de datos el combo de partidas.
        /// </summary>
        public void CargarPartida()
        {
            DataTable partida = new DataTable();
            //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
            GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql
            int ronda = Convert.ToInt32(cboRonda.SelectedValue);
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            try
            {
                partida = g.CargarPartida(ronda);

                // Se añade una row vacía al combo para que se muestre vacio al inicio.
                DataRow row = partida.NewRow();
                row["PARTIDA_NB_PARTIDA"] = "";
                row["PARTIDA_ID_PARTIDA"] = 0;
                partida.Rows.InsertAt(row, 0);

                cboPartida.DisplayMember = "PARTIDA_NB_PARTIDA";
                cboPartida.ValueMember = "PARTIDA_ID_PARTIDA";
                cboPartida.DataSource = partida;

                // Autocompletado.
                foreach (DataRow r in partida.Rows)
                {
                    stringCol.Add(Convert.ToString(r["PARTIDA_NB_PARTIDA"]));
                }

                cboPartida.AutoCompleteCustomSource = stringCol;
                cboPartida.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboPartida.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Método que llena de datos elcombo de invocador.
        /// </summary>
        public void CargarInvocador()
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
        /// Método que llena de datos elcombo de campeones.
        /// </summary>
        public void CargarCampeon()
        {
            DataTable campeon = new DataTable();
            //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
            GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            try
            {
                campeon = g.CargarCampeon();

                // Se añade una row vacía al combo para que se muestre vacio al inicio.
                DataRow row = campeon.NewRow();
                row["CAMPEON_NOMBRE"] = "";
                row["CAMPEON_ID"] = 0;
                campeon.Rows.InsertAt(row, 0);

                cboCampeon.DisplayMember = "CAMPEON_NOMBRE";
                cboCampeon.ValueMember = "CAMPEON_ID";
                cboCampeon.DataSource = campeon;

                // Autocompletado.
                foreach (DataRow r in campeon.Rows)
                {
                    stringCol.Add(Convert.ToString(r["CAMPEON_NOMBRE"]));
                }

                cboCampeon.AutoCompleteCustomSource = stringCol;
                cboCampeon.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboCampeon.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Comprueba si los textbox están vacios y si es así les asigna un 0.
        /// </summary>
        private void ComprobarVacios()
        {
            if (txtKills.Text.ToString() == string.Empty)
                txtKills.Text = "0";

            if (txtDefeats.Text.ToString() == string.Empty)
                txtDefeats.Text = "0";

            if (txtAssists.Text.ToString() == string.Empty)
                txtAssists.Text = "0";

            if (txtGold.Text.ToString() == string.Empty)
                txtGold.Text = "0";

            if (txtMinions.Text.ToString() == string.Empty)
                txtMinions.Text = "0";

            if (txtMiniNeutral.Text.ToString() == string.Empty)
                txtMiniNeutral.Text = "0";
        }

        /// <summary>
        /// Método que descarga los cambios y devuelve los campos al estado original.
        /// </summary>
        private void DescartarCambios()
        {
            if (MessageBox.Show(Resources.QUESTION_DESCARTAR_CAMBIOS,
                                Resources.QUESTION_DESCARTAR_TITULO,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                // Restablece los text box.
                txtAssists.Text = "0";
                txtDefeats.Text = "0";
                txtKills.Text = "0";
                txtKDA.Text = "0";
                txtGold.Text = "0";
                txtMinions.Text = "0";
                txtMiniNeutral.Text = "0";

                // Restablece los radio button.
                rdbWin.Checked = false;
                rdbLost.Checked = false;

                // Restablece los combo box.
                cboCampeon.SelectedValue = 0;
                cboInvocador.SelectedValue = 0;
                cboPartida.SelectedValue = 0;
                cboRonda.SelectedValue = 0;

                // Establece el foco en en el cboRonda
                cboRonda.Focus();
            }
        }

        #endregion

       
       
    }
}
