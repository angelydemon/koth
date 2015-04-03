namespace Estadisticas.Vistas
{
    partial class frmBuscarInvocador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbCriteria = new System.Windows.Forms.GroupBox();
            this.cboInvocador = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_Search = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip_EditInvocador = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip_DeleteInvocador = new System.Windows.Forms.ToolStripLabel();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbEstadisticas = new System.Windows.Forms.GroupBox();
            this.txtNombreEsta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKDA = new System.Windows.Forms.TextBox();
            this.lblDKA = new System.Windows.Forms.Label();
            this.txtAssists = new System.Windows.Forms.TextBox();
            this.txtDefeats = new System.Windows.Forms.TextBox();
            this.txtKills = new System.Windows.Forms.TextBox();
            this.lblAsistencias = new System.Windows.Forms.Label();
            this.lblMuertes = new System.Windows.Forms.Label();
            this.lblAsesinatos = new System.Windows.Forms.Label();
            this.txtMiniNeutral = new System.Windows.Forms.TextBox();
            this.lblSubditosNeutrales = new System.Windows.Forms.Label();
            this.txtMinions = new System.Windows.Forms.TextBox();
            this.lblSubditos = new System.Windows.Forms.Label();
            this.txtGold = new System.Windows.Forms.TextBox();
            this.lblOro = new System.Windows.Forms.Label();
            this.toolStrip_EditEsta = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip_DeleteEsta = new System.Windows.Forms.ToolStripLabel();
            this.grbCriteria.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grbEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCriteria
            // 
            this.grbCriteria.Controls.Add(this.cboInvocador);
            this.grbCriteria.Controls.Add(this.lblNombre);
            this.grbCriteria.Location = new System.Drawing.Point(12, 28);
            this.grbCriteria.Name = "grbCriteria";
            this.grbCriteria.Size = new System.Drawing.Size(319, 86);
            this.grbCriteria.TabIndex = 0;
            this.grbCriteria.TabStop = false;
            this.grbCriteria.Text = "Buscar Invocador";
            // 
            // cboInvocador
            // 
            this.cboInvocador.FormattingEnabled = true;
            this.cboInvocador.Location = new System.Drawing.Point(75, 34);
            this.cboInvocador.Name = "cboInvocador";
            this.cboInvocador.Size = new System.Drawing.Size(137, 21);
            this.cboInvocador.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Search,
            this.toolStrip_EditInvocador,
            this.toolStrip_DeleteInvocador,
            this.toolStrip_EditEsta,
            this.toolStrip_DeleteEsta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(427, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_Search
            // 
            this.toolStrip_Search.Name = "toolStrip_Search";
            this.toolStrip_Search.Size = new System.Drawing.Size(42, 22);
            this.toolStrip_Search.Text = "Buscar";
            this.toolStrip_Search.Click += new System.EventHandler(this.toolStrip_Search_Click);
            // 
            // toolStrip_EditInvocador
            // 
            this.toolStrip_EditInvocador.Name = "toolStrip_EditInvocador";
            this.toolStrip_EditInvocador.Size = new System.Drawing.Size(58, 22);
            this.toolStrip_EditInvocador.Text = "Modificar";
            this.toolStrip_EditInvocador.Click += new System.EventHandler(this.toolStrip_Edit_Click);
            // 
            // toolStrip_DeleteInvocador
            // 
            this.toolStrip_DeleteInvocador.Name = "toolStrip_DeleteInvocador";
            this.toolStrip_DeleteInvocador.Size = new System.Drawing.Size(50, 22);
            this.toolStrip_DeleteInvocador.Text = "Eliminar";
            this.toolStrip_DeleteInvocador.Click += new System.EventHandler(this.toolStrip_Delete_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtEmail);
            this.grbDatos.Controls.Add(this.lblEmail);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Location = new System.Drawing.Point(12, 134);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(321, 100);
            this.grbDatos.TabIndex = 2;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos Invocador";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 53);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 56);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // grbEstadisticas
            // 
            this.grbEstadisticas.Controls.Add(this.txtMiniNeutral);
            this.grbEstadisticas.Controls.Add(this.txtKDA);
            this.grbEstadisticas.Controls.Add(this.lblSubditosNeutrales);
            this.grbEstadisticas.Controls.Add(this.txtNombreEsta);
            this.grbEstadisticas.Controls.Add(this.txtMinions);
            this.grbEstadisticas.Controls.Add(this.lblDKA);
            this.grbEstadisticas.Controls.Add(this.lblSubditos);
            this.grbEstadisticas.Controls.Add(this.label3);
            this.grbEstadisticas.Controls.Add(this.txtGold);
            this.grbEstadisticas.Controls.Add(this.txtAssists);
            this.grbEstadisticas.Controls.Add(this.lblOro);
            this.grbEstadisticas.Controls.Add(this.lblAsesinatos);
            this.grbEstadisticas.Controls.Add(this.txtDefeats);
            this.grbEstadisticas.Controls.Add(this.lblMuertes);
            this.grbEstadisticas.Controls.Add(this.txtKills);
            this.grbEstadisticas.Controls.Add(this.lblAsistencias);
            this.grbEstadisticas.Location = new System.Drawing.Point(12, 134);
            this.grbEstadisticas.Name = "grbEstadisticas";
            this.grbEstadisticas.Size = new System.Drawing.Size(401, 129);
            this.grbEstadisticas.TabIndex = 4;
            this.grbEstadisticas.TabStop = false;
            this.grbEstadisticas.Text = "Estadísticas Invocador";
            // 
            // txtNombreEsta
            // 
            this.txtNombreEsta.Location = new System.Drawing.Point(74, 27);
            this.txtNombreEsta.Name = "txtNombreEsta";
            this.txtNombreEsta.Size = new System.Drawing.Size(143, 20);
            this.txtNombreEsta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // txtKDA
            // 
            this.txtKDA.Location = new System.Drawing.Point(179, 84);
            this.txtKDA.Name = "txtKDA";
            this.txtKDA.Size = new System.Drawing.Size(38, 20);
            this.txtKDA.TabIndex = 13;
            this.txtKDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDKA
            // 
            this.lblDKA.AutoSize = true;
            this.lblDKA.Location = new System.Drawing.Point(126, 88);
            this.lblDKA.Name = "lblDKA";
            this.lblDKA.Size = new System.Drawing.Size(32, 13);
            this.lblDKA.TabIndex = 14;
            this.lblDKA.Text = "KDA:";
            // 
            // txtAssists
            // 
            this.txtAssists.BackColor = System.Drawing.SystemColors.Window;
            this.txtAssists.Location = new System.Drawing.Point(74, 83);
            this.txtAssists.MaxLength = 50;
            this.txtAssists.Name = "txtAssists";
            this.txtAssists.Size = new System.Drawing.Size(38, 20);
            this.txtAssists.TabIndex = 12;
            this.txtAssists.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDefeats
            // 
            this.txtDefeats.BackColor = System.Drawing.SystemColors.Window;
            this.txtDefeats.Location = new System.Drawing.Point(179, 57);
            this.txtDefeats.MaxLength = 50;
            this.txtDefeats.Name = "txtDefeats";
            this.txtDefeats.Size = new System.Drawing.Size(38, 20);
            this.txtDefeats.TabIndex = 10;
            this.txtDefeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKills
            // 
            this.txtKills.BackColor = System.Drawing.SystemColors.Window;
            this.txtKills.Location = new System.Drawing.Point(74, 57);
            this.txtKills.MaxLength = 50;
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(38, 20);
            this.txtKills.TabIndex = 8;
            this.txtKills.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAsistencias
            // 
            this.lblAsistencias.AutoSize = true;
            this.lblAsistencias.Location = new System.Drawing.Point(21, 87);
            this.lblAsistencias.Name = "lblAsistencias";
            this.lblAsistencias.Size = new System.Drawing.Size(42, 13);
            this.lblAsistencias.TabIndex = 11;
            this.lblAsistencias.Text = "Assists:";
            // 
            // lblMuertes
            // 
            this.lblMuertes.AutoSize = true;
            this.lblMuertes.Location = new System.Drawing.Point(125, 61);
            this.lblMuertes.Name = "lblMuertes";
            this.lblMuertes.Size = new System.Drawing.Size(47, 13);
            this.lblMuertes.TabIndex = 9;
            this.lblMuertes.Text = "Defeats:";
            // 
            // lblAsesinatos
            // 
            this.lblAsesinatos.AutoSize = true;
            this.lblAsesinatos.Location = new System.Drawing.Point(21, 60);
            this.lblAsesinatos.Name = "lblAsesinatos";
            this.lblAsesinatos.Size = new System.Drawing.Size(28, 13);
            this.lblAsesinatos.TabIndex = 7;
            this.lblAsesinatos.Text = "Kills:";
            // 
            // txtMiniNeutral
            // 
            this.txtMiniNeutral.Location = new System.Drawing.Point(334, 87);
            this.txtMiniNeutral.Name = "txtMiniNeutral";
            this.txtMiniNeutral.Size = new System.Drawing.Size(52, 20);
            this.txtMiniNeutral.TabIndex = 10;
            this.txtMiniNeutral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubditosNeutrales
            // 
            this.lblSubditosNeutrales.AutoSize = true;
            this.lblSubditosNeutrales.Location = new System.Drawing.Point(233, 90);
            this.lblSubditosNeutrales.Name = "lblSubditosNeutrales";
            this.lblSubditosNeutrales.Size = new System.Drawing.Size(97, 13);
            this.lblSubditosNeutrales.TabIndex = 12;
            this.lblSubditosNeutrales.Text = "Subditos neutrales:";
            // 
            // txtMinions
            // 
            this.txtMinions.Location = new System.Drawing.Point(334, 60);
            this.txtMinions.Name = "txtMinions";
            this.txtMinions.Size = new System.Drawing.Size(52, 20);
            this.txtMinions.TabIndex = 9;
            this.txtMinions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubditos
            // 
            this.lblSubditos.AutoSize = true;
            this.lblSubditos.Location = new System.Drawing.Point(233, 63);
            this.lblSubditos.Name = "lblSubditos";
            this.lblSubditos.Size = new System.Drawing.Size(51, 13);
            this.lblSubditos.TabIndex = 11;
            this.lblSubditos.Text = "Subditos:";
            // 
            // txtGold
            // 
            this.txtGold.Location = new System.Drawing.Point(334, 31);
            this.txtGold.Name = "txtGold";
            this.txtGold.Size = new System.Drawing.Size(52, 20);
            this.txtGold.TabIndex = 7;
            this.txtGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOro
            // 
            this.lblOro.AutoSize = true;
            this.lblOro.Location = new System.Drawing.Point(233, 34);
            this.lblOro.Name = "lblOro";
            this.lblOro.Size = new System.Drawing.Size(27, 13);
            this.lblOro.TabIndex = 8;
            this.lblOro.Text = "Oro:";
            // 
            // toolStrip_EditEsta
            // 
            this.toolStrip_EditEsta.Enabled = false;
            this.toolStrip_EditEsta.Name = "toolStrip_EditEsta";
            this.toolStrip_EditEsta.Size = new System.Drawing.Size(58, 22);
            this.toolStrip_EditEsta.Text = "Modificar";
            // 
            // toolStrip_DeleteEsta
            // 
            this.toolStrip_DeleteEsta.Enabled = false;
            this.toolStrip_DeleteEsta.Name = "toolStrip_DeleteEsta";
            this.toolStrip_DeleteEsta.Size = new System.Drawing.Size(50, 22);
            this.toolStrip_DeleteEsta.Text = "Eliminar";
            // 
            // frmBuscarInvocador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 281);
            this.Controls.Add(this.grbEstadisticas);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grbCriteria);
            this.Name = "frmBuscarInvocador";
            this.Text = "Buscar Invocador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBuscarInvocador_Load);
            this.grbCriteria.ResumeLayout(false);
            this.grbCriteria.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grbEstadisticas.ResumeLayout(false);
            this.grbEstadisticas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCriteria;
        private System.Windows.Forms.ComboBox cboInvocador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripLabel toolStrip_EditInvocador;
        private System.Windows.Forms.ToolStripLabel toolStrip_DeleteInvocador;
        private System.Windows.Forms.ToolStripLabel toolStrip_Search;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grbEstadisticas;
        private System.Windows.Forms.TextBox txtNombreEsta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKDA;
        private System.Windows.Forms.Label lblDKA;
        private System.Windows.Forms.TextBox txtAssists;
        private System.Windows.Forms.Label lblAsesinatos;
        private System.Windows.Forms.TextBox txtDefeats;
        private System.Windows.Forms.Label lblMuertes;
        private System.Windows.Forms.TextBox txtKills;
        private System.Windows.Forms.Label lblAsistencias;
        private System.Windows.Forms.TextBox txtMiniNeutral;
        private System.Windows.Forms.Label lblSubditosNeutrales;
        private System.Windows.Forms.TextBox txtMinions;
        private System.Windows.Forms.Label lblSubditos;
        private System.Windows.Forms.TextBox txtGold;
        private System.Windows.Forms.Label lblOro;
        private System.Windows.Forms.ToolStripLabel toolStrip_EditEsta;
        private System.Windows.Forms.ToolStripLabel toolStrip_DeleteEsta;
    }
}