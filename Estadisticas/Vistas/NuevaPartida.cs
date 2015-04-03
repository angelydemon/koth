using Operaciones;
using System;
using System.Data;
using System.Windows.Forms;

namespace Estadisticas.Vistas
{
    public partial class frmNuevaPartida : Form
    {

        #region Constructor

        public frmNuevaPartida()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Método que carga el formulario.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Guarda los datos en la BBDD.</param>
        private void frmNuevaPartida_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        /// <summary>
        /// Método para guardar una nueva partida.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Guarda los datos en la BBDD.</param>
        private void tool_Save_Click(object sender, EventArgs e)
        {
            //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
            GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql
            if (g.BuscarPartida(txtPartida.Text, cboRonda.SelectedIndex))
            {
                g.NuevaPartida(Convert.ToInt32(cboRonda.SelectedValue.ToString()), txtPartida.Text);
                this.Close();
            }
            else
                MessageBox.Show("Ya existe una partida con ese nombre.", "Nombre duplicado",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        /// <summary>
        /// Método para deshacer los cambios que se hallan hecho.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Borra los TextBox.</param>
        private void tool_Discard_Click(object sender, EventArgs e)
        {
            txtPartida.Text = string.Empty;
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

        #endregion

        #region Métodos.

        /// <summary>
        /// Método que llama a las funciones para cargar los combo box
        /// </summary>
        public void CargarCombos()
        {
            CargarRonda();
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

        #endregion
        
    }
}
