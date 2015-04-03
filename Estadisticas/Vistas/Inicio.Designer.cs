namespace Estadisticas
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.tool_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_Configuración = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCampeon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAdd_Campeon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolInvocadores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAdd_Invocador = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSearch_Invocador = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAdd_Estadistica = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRonda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAdd_NuevaRonda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAdd_NuevaPartida = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_ClasificacionGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_EstadisticasInvocador = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tooSearch_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.mstMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mstMenu
            // 
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_Archivo,
            this.toolCampeon,
            this.toolInvocadores,
            this.toolRonda,
            this.clasificaciónToolStripMenuItem,
            this.tool_Ayuda});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(780, 24);
            this.mstMenu.TabIndex = 1;
            this.mstMenu.Text = "menuStrip1";
            // 
            // tool_Archivo
            // 
            this.tool_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_Configuración,
            this.toolStripSeparator1,
            this.tool_Salir});
            this.tool_Archivo.Name = "tool_Archivo";
            this.tool_Archivo.Size = new System.Drawing.Size(60, 20);
            this.tool_Archivo.Text = "&Archivo";
            // 
            // tool_Configuración
            // 
            this.tool_Configuración.Enabled = false;
            this.tool_Configuración.Name = "tool_Configuración";
            this.tool_Configuración.Size = new System.Drawing.Size(159, 22);
            this.tool_Configuración.Text = "&Configuración...";
            this.tool_Configuración.Click += new System.EventHandler(this.toolConfiguración_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // tool_Salir
            // 
            this.tool_Salir.Name = "tool_Salir";
            this.tool_Salir.Size = new System.Drawing.Size(159, 22);
            this.tool_Salir.Text = "&Salir";
            this.tool_Salir.Click += new System.EventHandler(this.tool_Salir_Click);
            // 
            // toolCampeon
            // 
            this.toolCampeon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd_Campeon});
            this.toolCampeon.Name = "toolCampeon";
            this.toolCampeon.Size = new System.Drawing.Size(71, 20);
            this.toolCampeon.Text = "Ca&mpeón";
            // 
            // toolAdd_Campeon
            // 
            this.toolAdd_Campeon.Name = "toolAdd_Campeon";
            this.toolAdd_Campeon.Size = new System.Drawing.Size(164, 22);
            this.toolAdd_Campeon.Text = "Añadir &Campeón";
            this.toolAdd_Campeon.Click += new System.EventHandler(this.toolAdd_Campeon_Click);
            // 
            // toolInvocadores
            // 
            this.toolInvocadores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd_Invocador,
            this.toolSearch_Invocador,
            this.toolAdd_Estadistica});
            this.toolInvocadores.Name = "toolInvocadores";
            this.toolInvocadores.Size = new System.Drawing.Size(83, 20);
            this.toolInvocadores.Text = "&Invocadores";
            // 
            // toolAdd_Invocador
            // 
            this.toolAdd_Invocador.Name = "toolAdd_Invocador";
            this.toolAdd_Invocador.Size = new System.Drawing.Size(176, 22);
            this.toolAdd_Invocador.Text = "Añadir &Invocador...";
            this.toolAdd_Invocador.Click += new System.EventHandler(this.toolAdd_Invocador_Click);
            // 
            // toolSearch_Invocador
            // 
            this.toolSearch_Invocador.Name = "toolSearch_Invocador";
            this.toolSearch_Invocador.Size = new System.Drawing.Size(176, 22);
            this.toolSearch_Invocador.Text = "&Buscar Invocador...";
            this.toolSearch_Invocador.Click += new System.EventHandler(this.toolSearch_Invocador_Click);
            // 
            // toolAdd_Estadistica
            // 
            this.toolAdd_Estadistica.Name = "toolAdd_Estadistica";
            this.toolAdd_Estadistica.Size = new System.Drawing.Size(176, 22);
            this.toolAdd_Estadistica.Text = "Añadir &Estadística...";
            this.toolAdd_Estadistica.Click += new System.EventHandler(this.toolAdd_Estadistica_Click);
            // 
            // toolRonda
            // 
            this.toolRonda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd_NuevaRonda,
            this.toolAdd_NuevaPartida});
            this.toolRonda.Name = "toolRonda";
            this.toolRonda.Size = new System.Drawing.Size(53, 20);
            this.toolRonda.Text = "&Ronda";
            // 
            // toolAdd_NuevaRonda
            // 
            this.toolAdd_NuevaRonda.Name = "toolAdd_NuevaRonda";
            this.toolAdd_NuevaRonda.Size = new System.Drawing.Size(157, 22);
            this.toolAdd_NuevaRonda.Text = "Nueva &Ronda...";
            this.toolAdd_NuevaRonda.Click += new System.EventHandler(this.toolAdd_NuevaRonda_Click);
            // 
            // toolAdd_NuevaPartida
            // 
            this.toolAdd_NuevaPartida.Name = "toolAdd_NuevaPartida";
            this.toolAdd_NuevaPartida.Size = new System.Drawing.Size(157, 22);
            this.toolAdd_NuevaPartida.Text = "Nueva &Partida...";
            this.toolAdd_NuevaPartida.Click += new System.EventHandler(this.nuevaPartidaToolStripMenuItem_Click);
            // 
            // clasificaciónToolStripMenuItem
            // 
            this.clasificaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_ClasificacionGeneral,
            this.tool_EstadisticasInvocador});
            this.clasificaciónToolStripMenuItem.Name = "clasificaciónToolStripMenuItem";
            this.clasificaciónToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.clasificaciónToolStripMenuItem.Text = "&Clasificación";
            // 
            // tool_ClasificacionGeneral
            // 
            this.tool_ClasificacionGeneral.Name = "tool_ClasificacionGeneral";
            this.tool_ClasificacionGeneral.Size = new System.Drawing.Size(199, 22);
            this.tool_ClasificacionGeneral.Text = "Clasificación &General";
            this.tool_ClasificacionGeneral.Click += new System.EventHandler(this.tool_ClasificacionGeneral_Click);
            // 
            // tool_EstadisticasInvocador
            // 
            this.tool_EstadisticasInvocador.Name = "tool_EstadisticasInvocador";
            this.tool_EstadisticasInvocador.Size = new System.Drawing.Size(199, 22);
            this.tool_EstadisticasInvocador.Text = "Estadísticas &Invocador...";
            this.tool_EstadisticasInvocador.Click += new System.EventHandler(this.tool_EstadisticasInvocador_Click);
            // 
            // tool_Ayuda
            // 
            this.tool_Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_ayuda,
            this.tool_AcercaDe,
            this.toolStripSeparator2,
            this.tooSearch_Update});
            this.tool_Ayuda.Name = "tool_Ayuda";
            this.tool_Ayuda.Size = new System.Drawing.Size(53, 20);
            this.tool_Ayuda.Text = "A&yuda";
            // 
            // toolStrip_ayuda
            // 
            this.toolStrip_ayuda.Enabled = false;
            this.toolStrip_ayuda.Name = "toolStrip_ayuda";
            this.toolStrip_ayuda.Size = new System.Drawing.Size(194, 22);
            this.toolStrip_ayuda.Text = "&Ayuda";
            this.toolStrip_ayuda.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // tool_AcercaDe
            // 
            this.tool_AcercaDe.Name = "tool_AcercaDe";
            this.tool_AcercaDe.Size = new System.Drawing.Size(194, 22);
            this.tool_AcercaDe.Text = "A&cerca de...";
            this.tool_AcercaDe.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // tooSearch_Update
            // 
            this.tooSearch_Update.Name = "tooSearch_Update";
            this.tooSearch_Update.Size = new System.Drawing.Size(194, 22);
            this.tooSearch_Update.Text = "&Buscar Actualizaciones";
            this.tooSearch_Update.Click += new System.EventHandler(this.tooSearch_Update_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Estadisticas.Properties.Resources.LogoKothWinter2015;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(780, 438);
            this.Controls.Add(this.mstMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "King of the Hill";
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.ToolStripMenuItem tool_Archivo;
        private System.Windows.Forms.ToolStripMenuItem tool_Salir;
        private System.Windows.Forms.ToolStripMenuItem toolInvocadores;
        private System.Windows.Forms.ToolStripMenuItem toolAdd_Invocador;
        private System.Windows.Forms.ToolStripMenuItem toolRonda;
        private System.Windows.Forms.ToolStripMenuItem toolAdd_NuevaRonda;
        private System.Windows.Forms.ToolStripMenuItem tool_Ayuda;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem toolSearch_Invocador;
        private System.Windows.Forms.ToolStripMenuItem toolAdd_NuevaPartida;
        private System.Windows.Forms.ToolStripMenuItem tool_Configuración;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolAdd_Estadistica;
        private System.Windows.Forms.ToolStripMenuItem clasificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tool_ClasificacionGeneral;
        private System.Windows.Forms.ToolStripMenuItem tool_EstadisticasInvocador;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_ayuda;
        private System.Windows.Forms.ToolStripMenuItem tool_AcercaDe;
        private System.Windows.Forms.ToolStripMenuItem toolCampeon;
        private System.Windows.Forms.ToolStripMenuItem toolAdd_Campeon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tooSearch_Update;
    }
}

