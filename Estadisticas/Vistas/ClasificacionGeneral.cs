using Operaciones;
using System;
using System.Windows.Forms;

namespace Estadisticas.Vistas
{
    public partial class frmClasificacionGeneral : Form
    {
        public frmClasificacionGeneral()
        {
            InitializeComponent();
        }

        private void frmClasificacionGeneral_Load(object sender, EventArgs e)
        {
            //GestionMSSQL g = new GestionMSSQL();  //Para conexion con MSSql
            GestionMYSQL g = new GestionMYSQL();    //Para conexión con MySql
            dgvListado.DataSource = g.CargarClasificacion();
        }

        #region Eventos

        /// <summary>
        /// Llama al método para exportar el grid a excel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tool_Exportar_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvListado);
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método que exporta los datos del grid a una hoja de Excel.
        /// </summary>
        /// <param name="grd"></param>
        private void ExportarDataGridViewExcel(DataGridView grd)
        {            
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in grd.Columns) // Columnas
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in grd.Rows) // Filas
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in grd.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }

            excel.Visible = true;
        }

        #endregion
    }
}
