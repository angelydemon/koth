#region Librerias

using Estadisticas.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace Estadisticas
{
    public partial class frmInicio : Form
    {
        #region Variables globales

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public frmInicio()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Método para salir de la aplicaicón.
        /// </summary>
        /// <param name="sender">Objecto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void tool_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Evento que llama al método para mostrar la ventana nuevo invocador.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void toolAdd_Invocador_Click(object sender, EventArgs e)
        {
            AddInvocador();
            
        }        
        
        /// <summary>
        /// Evento que llama al método para mostrar la ventana nueva ronda.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void toolAdd_NuevaRonda_Click(object sender, EventArgs e)
        {
            AddNuevaRonda();            
        }        
        
        /// <summary>
        /// Evento que llama al método para mostrar la ventana nueva partida.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void nuevaPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNuevaPartida();            
        }
        

        /// <summary>
        /// Evento que llama al método para mosrar la ventana nueva estadística.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolAdd_Estadistica_Click(object sender, EventArgs e)
        {
            AddEstadistica();            
        }        

        /// <summary>
        /// Eventoq ue llama al método para mostrar el cuadro de dialogo Configuración.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void toolConfiguración_Click(object sender, EventArgs e)
        {
            ShowConfiguracion();            
        }        

        /// <summary>
        /// Evento que llama´al método para mostrar la clasificación general.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void tool_ClasificacionGeneral_Click(object sender, EventArgs e)
        {
            ShowClasificacion();            
        }        

        /// <summary>
        /// Llama al formulario hijo buscar invocador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolSearch_Invocador_Click(object sender, EventArgs e)
        {
            MostrarInvocador();            
        }
        
        /// <summary>
        /// Llama al evento que muestra la ayuda.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarAyuda();
        }

        /// <summary>
        /// Evento que muestra el cuadro Acerca de...
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarAcercaDe();
        }

        /// <summary>
        /// Evento que llama al formulario hijo buscar invocador.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void tool_EstadisticasInvocador_Click(object sender, EventArgs e)
        {
            MostrarEstadisticasInvocador();            
        }

        /// <summary>
        /// Evento que llama al método para actualizar la aplicación.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void tooSearch_Update_Click(object sender, EventArgs e)
        {
            //TODO
            //InstallUpdateSyncWithInfo();
        }

        /// <summary>
        /// Evento que llama al método para mostrar formulario nuevo campeón.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumento del evento.</param>
        private void toolAdd_Campeon_Click(object sender, EventArgs e)
        {
            AddNuevoCampeon();
        }

        #endregion
        
        #region Métodos privados

        /// <summary>
        /// Método que llama a la ventana para dar de alta un nuevo invocador.
        /// </summary>
        private void AddInvocador()
        {
            // Se crea un nuevo formulario hijo.
            frmNuevoInvocador NuevoInvocador = new frmNuevoInvocador();

            // Establecer el formulario padre del hijo.
            NuevoInvocador.MdiParent = this;

            // Mostrar el formulario hijo.
            NuevoInvocador.Show();
        }

        /// <summary>
        /// Método que llama a la ventana nueva ronda.
        /// </summary>
        private void AddNuevaRonda()
        {
            // Se crea un nuevo formulario hijo.
            frmNuevaRonda NuevaRonda = new frmNuevaRonda();

            // Establece el formulario padre del hijo.
            NuevaRonda.MdiParent = this;

            // Mostrar el formulario hijo.
            NuevaRonda.Show();
        }

        /// <summary>
        /// Método que llama a la ventana alta nueva partida.
        /// </summary>
        private void AddNuevaPartida()
        {
            // Se crea un nuevo formulario hijo.
            frmNuevaPartida NuevaPartida = new frmNuevaPartida();

            // Establece el formulario padre del hijo.
            NuevaPartida.MdiParent = this;

            // Mostrar el formulario hijo.
            NuevaPartida.Show();
        }

        /// <summary>
        /// Método que llama a la ventana para añadir una nueva estadísitca.
        /// </summary>
        private void AddEstadistica()
        {
            // Se crea un nuevo formulario hijo.
            frmNuevaEstadistica NuevaEstadística = new frmNuevaEstadistica();

            // Establece el formulario padre.
            NuevaEstadística.MdiParent = this;

            // Muestra el formulario hijo.
            NuevaEstadística.Show();
        }

        /// <summary>
        /// Método que muestra el cuadro de diálogo Configuración.
        /// </summary>
        private void ShowConfiguracion()
        {
            // Se crea el nuevo formulario.
            frmConfiguracion Configuracion = new frmConfiguracion();

            // Muestra el cuadro de dialogo.
            Configuracion.ShowDialog();
        }

        /// <summary>
        /// Método que muestra la ventana de clasificación general.
        /// </summary>
        private void ShowClasificacion()
        {
            // Se crea un nuevo formulario hijo.
            frmClasificacionGeneral ClasificacionGeneral = new frmClasificacionGeneral();

            // Establece el formulario padre.
            ClasificacionGeneral.MdiParent = this;

            // Muestra el formulario hijo.
            ClasificacionGeneral.Show();
        }

        /// <summary>
        /// Evento que muestra el formulario NuevoCampeon.
        /// </summary>
        private void AddNuevoCampeon()
        {
            // Crea un nuevo formulraio hijo.
            frmNuevoCampeon nuevoCampeon = new frmNuevoCampeon();

            // Estabelce el formulario padre.
            nuevoCampeon.MdiParent = this;

            // Muestra el formulario hijo.
            nuevoCampeon.Show();
        }

        /// <summary>
        /// Muestra la ayuda de la aplicación.
        /// </summary>
        private void MostrarAyuda()
        {
            // EStablece la ruta de la ayuda.
            string rutaEjecutable = System.IO.Directory.GetCurrentDirectory().ToString();

            // Muestra la vetana de ayuda.
            System.Diagnostics.Process.Start(rutaEjecutable + "\\AyudaEstadisticasKoth.chm");
        }        

        /// <summary>
        /// Muestra el cuadro Acerca de...
        /// </summary>
        private void MostrarAcercaDe()
        {
            About acercaDe = new About();
            acercaDe.Show();
        }

        /// <summary>
        /// Llama al formulario de búsqueda de invocador para mostrar sus estadísticas.
        /// </summary>
        private void MostrarEstadisticasInvocador()
        {
            // Crea un nuevo formulario hijo.
            frmBuscarInvocador BuscarInvocador = new frmBuscarInvocador();

            BuscarInvocador.Invocador = false;
            BuscarInvocador.Estadistica = true;

            // Establece el formulario padre.
            BuscarInvocador.MdiParent = this;

            // Muestra el formulario hijo.
            BuscarInvocador.Show();
        }

        /// <summary>
        /// Llama al formulario de búsqueda de invocador para mostrar su datos.
        /// </summary>
        private void MostrarInvocador()
        {
            frmBuscarInvocador BuscarInvocador = new frmBuscarInvocador();

            BuscarInvocador.Invocador = true;
            BuscarInvocador.Estadistica = false;

            BuscarInvocador.MdiParent = this;

            BuscarInvocador.Show();
        }

        /// <summary>
        /// Método que comprueba si hay actualizaciones de la aplicación.
        /// </summary>
        private void InstallUpdateSyncWithInfo()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("En este momento no se puede descargar la nueva versión de la aplicaión. \n\nComprueba tu conexión o intentalo de nuevo más tarde. Error: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("Actualizaciones disponibles. ¿Deseas actualizar ahora?", "Actualización disponible", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("This application has detected a mandatory update from your current " +
                            "version to version " + info.MinimumRequiredVersion.ToString() +
                            ". The application will now install the update and restart.",
                            "Update Available", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("The application has been upgraded, and will now restart.");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Cannot install the latest version of the application. \n\nPlease check your network connection, or try again later. Error: " + dde);
                            return;
                        }
                    }
                }
            }
        }        

        #endregion                   
        
    }
}
