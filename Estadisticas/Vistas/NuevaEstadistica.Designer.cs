namespace Estadisticas.Vistas
{
    partial class frmNuevaEstadistica
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
            this.grbCriteriaDatos = new System.Windows.Forms.GroupBox();
            this.grbWinLost = new System.Windows.Forms.GroupBox();
            this.rdbLost = new System.Windows.Forms.RadioButton();
            this.rdbWin = new System.Windows.Forms.RadioButton();
            this.cboPartida = new System.Windows.Forms.ComboBox();
            this.cboInvocador = new System.Windows.Forms.ComboBox();
            this.cboRonda = new System.Windows.Forms.ComboBox();
            this.lblInvocador = new System.Windows.Forms.Label();
            this.lblPartida = new System.Windows.Forms.Label();
            this.lblRonda = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tool_Save = new System.Windows.Forms.ToolStripLabel();
            this.tool_Discard = new System.Windows.Forms.ToolStripLabel();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.grbCriteriaEstadistica = new System.Windows.Forms.GroupBox();
            this.cboCampeon = new System.Windows.Forms.ComboBox();
            this.lblCampeon = new System.Windows.Forms.Label();
            this.txtKDA = new System.Windows.Forms.TextBox();
            this.lblDKA = new System.Windows.Forms.Label();
            this.txtAssists = new System.Windows.Forms.TextBox();
            this.txtDefeats = new System.Windows.Forms.TextBox();
            this.txtKills = new System.Windows.Forms.TextBox();
            this.lblAsistencias = new System.Windows.Forms.Label();
            this.lblMuertes = new System.Windows.Forms.Label();
            this.lblAsesinatos = new System.Windows.Forms.Label();
            this.grbOtrasEstadisticas = new System.Windows.Forms.GroupBox();
            this.txtMiniNeutral = new System.Windows.Forms.TextBox();
            this.lblSubditosNeutrales = new System.Windows.Forms.Label();
            this.txtMinions = new System.Windows.Forms.TextBox();
            this.lblSubditos = new System.Windows.Forms.Label();
            this.txtGold = new System.Windows.Forms.TextBox();
            this.lblOro = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbCriteriaDatos.SuspendLayout();
            this.grbWinLost.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.grbCriteriaEstadistica.SuspendLayout();
            this.grbOtrasEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCriteriaDatos
            // 
            this.grbCriteriaDatos.Controls.Add(this.grbWinLost);
            this.grbCriteriaDatos.Controls.Add(this.cboPartida);
            this.grbCriteriaDatos.Controls.Add(this.cboInvocador);
            this.grbCriteriaDatos.Controls.Add(this.cboRonda);
            this.grbCriteriaDatos.Controls.Add(this.lblInvocador);
            this.grbCriteriaDatos.Controls.Add(this.lblPartida);
            this.grbCriteriaDatos.Controls.Add(this.lblRonda);
            this.grbCriteriaDatos.Location = new System.Drawing.Point(12, 28);
            this.grbCriteriaDatos.Name = "grbCriteriaDatos";
            this.grbCriteriaDatos.Size = new System.Drawing.Size(463, 89);
            this.grbCriteriaDatos.TabIndex = 9;
            this.grbCriteriaDatos.TabStop = false;
            this.grbCriteriaDatos.Text = "Datos de partida";
            // 
            // grbWinLost
            // 
            this.grbWinLost.Controls.Add(this.rdbLost);
            this.grbWinLost.Controls.Add(this.rdbWin);
            this.grbWinLost.Location = new System.Drawing.Point(355, 15);
            this.grbWinLost.Name = "grbWinLost";
            this.grbWinLost.Size = new System.Drawing.Size(101, 63);
            this.grbWinLost.TabIndex = 3;
            this.grbWinLost.TabStop = false;
            this.grbWinLost.Text = "Final";
            // 
            // rdbLost
            // 
            this.rdbLost.AutoSize = true;
            this.rdbLost.Location = new System.Drawing.Point(7, 40);
            this.rdbLost.Name = "rdbLost";
            this.rdbLost.Size = new System.Drawing.Size(45, 17);
            this.rdbLost.TabIndex = 1;
            this.rdbLost.TabStop = true;
            this.rdbLost.Text = "Lost";
            this.rdbLost.UseVisualStyleBackColor = true;
            // 
            // rdbWin
            // 
            this.rdbWin.AutoSize = true;
            this.rdbWin.Location = new System.Drawing.Point(7, 19);
            this.rdbWin.Name = "rdbWin";
            this.rdbWin.Size = new System.Drawing.Size(44, 17);
            this.rdbWin.TabIndex = 0;
            this.rdbWin.TabStop = true;
            this.rdbWin.Text = "Win";
            this.rdbWin.UseVisualStyleBackColor = true;
            // 
            // cboPartida
            // 
            this.cboPartida.BackColor = System.Drawing.SystemColors.Window;
            this.cboPartida.FormattingEnabled = true;
            this.cboPartida.Location = new System.Drawing.Point(65, 50);
            this.cboPartida.Name = "cboPartida";
            this.cboPartida.Size = new System.Drawing.Size(73, 21);
            this.cboPartida.TabIndex = 1;
            // 
            // cboInvocador
            // 
            this.cboInvocador.BackColor = System.Drawing.SystemColors.Window;
            this.cboInvocador.FormattingEnabled = true;
            this.cboInvocador.Location = new System.Drawing.Point(216, 25);
            this.cboInvocador.Name = "cboInvocador";
            this.cboInvocador.Size = new System.Drawing.Size(115, 21);
            this.cboInvocador.TabIndex = 2;
            // 
            // cboRonda
            // 
            this.cboRonda.BackColor = System.Drawing.SystemColors.Window;
            this.cboRonda.FormattingEnabled = true;
            this.cboRonda.Location = new System.Drawing.Point(65, 25);
            this.cboRonda.Name = "cboRonda";
            this.cboRonda.Size = new System.Drawing.Size(73, 21);
            this.cboRonda.TabIndex = 0;
            this.cboRonda.SelectedIndexChanged += new System.EventHandler(this.cboRonda_SelectedIndexChanged);
            // 
            // lblInvocador
            // 
            this.lblInvocador.AutoSize = true;
            this.lblInvocador.Location = new System.Drawing.Point(154, 28);
            this.lblInvocador.Name = "lblInvocador";
            this.lblInvocador.Size = new System.Drawing.Size(58, 13);
            this.lblInvocador.TabIndex = 2;
            this.lblInvocador.Text = "Invocador:";
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Location = new System.Drawing.Point(19, 54);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(43, 13);
            this.lblPartida.TabIndex = 1;
            this.lblPartida.Text = "Partida:";
            // 
            // lblRonda
            // 
            this.lblRonda.AutoSize = true;
            this.lblRonda.Location = new System.Drawing.Point(19, 30);
            this.lblRonda.Name = "lblRonda";
            this.lblRonda.Size = new System.Drawing.Size(42, 13);
            this.lblRonda.TabIndex = 0;
            this.lblRonda.Text = "Ronda:";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_Save,
            this.tool_Discard,
            this.toolSave});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(488, 25);
            this.toolStrip.TabIndex = 10;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tool_Save
            // 
            this.tool_Save.Name = "tool_Save";
            this.tool_Save.Size = new System.Drawing.Size(49, 22);
            this.tool_Save.Text = "Guardar";
            this.tool_Save.Click += new System.EventHandler(this.tool_Save_Click);
            // 
            // tool_Discard
            // 
            this.tool_Discard.Name = "tool_Discard";
            this.tool_Discard.Size = new System.Drawing.Size(56, 22);
            this.tool_Discard.Text = "Descartar";
            this.tool_Discard.Click += new System.EventHandler(this.tool_Discard_Click);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(23, 22);
            this.toolSave.Text = "Guardar";
            // 
            // grbCriteriaEstadistica
            // 
            this.grbCriteriaEstadistica.Controls.Add(this.cboCampeon);
            this.grbCriteriaEstadistica.Controls.Add(this.lblCampeon);
            this.grbCriteriaEstadistica.Controls.Add(this.txtKDA);
            this.grbCriteriaEstadistica.Controls.Add(this.lblDKA);
            this.grbCriteriaEstadistica.Controls.Add(this.txtAssists);
            this.grbCriteriaEstadistica.Controls.Add(this.txtDefeats);
            this.grbCriteriaEstadistica.Controls.Add(this.txtKills);
            this.grbCriteriaEstadistica.Controls.Add(this.lblAsistencias);
            this.grbCriteriaEstadistica.Controls.Add(this.lblMuertes);
            this.grbCriteriaEstadistica.Controls.Add(this.lblAsesinatos);
            this.grbCriteriaEstadistica.Location = new System.Drawing.Point(12, 137);
            this.grbCriteriaEstadistica.Name = "grbCriteriaEstadistica";
            this.grbCriteriaEstadistica.Size = new System.Drawing.Size(220, 116);
            this.grbCriteriaEstadistica.TabIndex = 10;
            this.grbCriteriaEstadistica.TabStop = false;
            this.grbCriteriaEstadistica.Text = "Estadísticas de jugador";
            // 
            // cboCampeon
            // 
            this.cboCampeon.BackColor = System.Drawing.SystemColors.Window;
            this.cboCampeon.DisplayMember = "RONDA_ID_RONDA";
            this.cboCampeon.FormattingEnabled = true;
            this.cboCampeon.Location = new System.Drawing.Point(65, 27);
            this.cboCampeon.Name = "cboCampeon";
            this.cboCampeon.Size = new System.Drawing.Size(143, 21);
            this.cboCampeon.TabIndex = 0;
            this.cboCampeon.ValueMember = "RONDA_ID_RONDA";
            // 
            // lblCampeon
            // 
            this.lblCampeon.AutoSize = true;
            this.lblCampeon.Location = new System.Drawing.Point(12, 30);
            this.lblCampeon.Name = "lblCampeon";
            this.lblCampeon.Size = new System.Drawing.Size(55, 13);
            this.lblCampeon.TabIndex = 8;
            this.lblCampeon.Text = "Campeón:";
            // 
            // txtKDA
            // 
            this.txtKDA.Location = new System.Drawing.Point(170, 82);
            this.txtKDA.Name = "txtKDA";
            this.txtKDA.Size = new System.Drawing.Size(38, 20);
            this.txtKDA.TabIndex = 4;
            this.txtKDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDKA
            // 
            this.lblDKA.AutoSize = true;
            this.lblDKA.Location = new System.Drawing.Point(117, 86);
            this.lblDKA.Name = "lblDKA";
            this.lblDKA.Size = new System.Drawing.Size(32, 13);
            this.lblDKA.TabIndex = 6;
            this.lblDKA.Text = "KDA:";
            // 
            // txtAssists
            // 
            this.txtAssists.BackColor = System.Drawing.SystemColors.Window;
            this.txtAssists.Location = new System.Drawing.Point(65, 81);
            this.txtAssists.MaxLength = 50;
            this.txtAssists.Name = "txtAssists";
            this.txtAssists.Size = new System.Drawing.Size(38, 20);
            this.txtAssists.TabIndex = 3;
            this.txtAssists.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAssists.TextChanged += new System.EventHandler(this.txtAssists_TextChanged);
            this.txtAssists.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtDefeats
            // 
            this.txtDefeats.BackColor = System.Drawing.SystemColors.Window;
            this.txtDefeats.Location = new System.Drawing.Point(170, 55);
            this.txtDefeats.MaxLength = 50;
            this.txtDefeats.Name = "txtDefeats";
            this.txtDefeats.Size = new System.Drawing.Size(38, 20);
            this.txtDefeats.TabIndex = 2;
            this.txtDefeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDefeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtKills
            // 
            this.txtKills.BackColor = System.Drawing.SystemColors.Window;
            this.txtKills.Location = new System.Drawing.Point(65, 55);
            this.txtKills.MaxLength = 50;
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(38, 20);
            this.txtKills.TabIndex = 1;
            this.txtKills.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKills.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblAsistencias
            // 
            this.lblAsistencias.AutoSize = true;
            this.lblAsistencias.Location = new System.Drawing.Point(12, 85);
            this.lblAsistencias.Name = "lblAsistencias";
            this.lblAsistencias.Size = new System.Drawing.Size(42, 13);
            this.lblAsistencias.TabIndex = 2;
            this.lblAsistencias.Text = "Assists:";
            // 
            // lblMuertes
            // 
            this.lblMuertes.AutoSize = true;
            this.lblMuertes.Location = new System.Drawing.Point(116, 59);
            this.lblMuertes.Name = "lblMuertes";
            this.lblMuertes.Size = new System.Drawing.Size(47, 13);
            this.lblMuertes.TabIndex = 1;
            this.lblMuertes.Text = "Defeats:";
            // 
            // lblAsesinatos
            // 
            this.lblAsesinatos.AutoSize = true;
            this.lblAsesinatos.Location = new System.Drawing.Point(12, 58);
            this.lblAsesinatos.Name = "lblAsesinatos";
            this.lblAsesinatos.Size = new System.Drawing.Size(28, 13);
            this.lblAsesinatos.TabIndex = 0;
            this.lblAsesinatos.Text = "Kills:";
            // 
            // grbOtrasEstadisticas
            // 
            this.grbOtrasEstadisticas.Controls.Add(this.txtMiniNeutral);
            this.grbOtrasEstadisticas.Controls.Add(this.lblSubditosNeutrales);
            this.grbOtrasEstadisticas.Controls.Add(this.txtMinions);
            this.grbOtrasEstadisticas.Controls.Add(this.lblSubditos);
            this.grbOtrasEstadisticas.Controls.Add(this.txtGold);
            this.grbOtrasEstadisticas.Controls.Add(this.lblOro);
            this.grbOtrasEstadisticas.Location = new System.Drawing.Point(254, 137);
            this.grbOtrasEstadisticas.Name = "grbOtrasEstadisticas";
            this.grbOtrasEstadisticas.Size = new System.Drawing.Size(220, 116);
            this.grbOtrasEstadisticas.TabIndex = 11;
            this.grbOtrasEstadisticas.TabStop = false;
            this.grbOtrasEstadisticas.Text = "Otras estadísticas";
            // 
            // txtMiniNeutral
            // 
            this.txtMiniNeutral.Location = new System.Drawing.Point(113, 83);
            this.txtMiniNeutral.Name = "txtMiniNeutral";
            this.txtMiniNeutral.Size = new System.Drawing.Size(52, 20);
            this.txtMiniNeutral.TabIndex = 2;
            this.txtMiniNeutral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMiniNeutral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblSubditosNeutrales
            // 
            this.lblSubditosNeutrales.AutoSize = true;
            this.lblSubditosNeutrales.Location = new System.Drawing.Point(12, 86);
            this.lblSubditosNeutrales.Name = "lblSubditosNeutrales";
            this.lblSubditosNeutrales.Size = new System.Drawing.Size(97, 13);
            this.lblSubditosNeutrales.TabIndex = 6;
            this.lblSubditosNeutrales.Text = "Subditos neutrales:";
            // 
            // txtMinions
            // 
            this.txtMinions.Location = new System.Drawing.Point(113, 56);
            this.txtMinions.Name = "txtMinions";
            this.txtMinions.Size = new System.Drawing.Size(52, 20);
            this.txtMinions.TabIndex = 1;
            this.txtMinions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblSubditos
            // 
            this.lblSubditos.AutoSize = true;
            this.lblSubditos.Location = new System.Drawing.Point(12, 59);
            this.lblSubditos.Name = "lblSubditos";
            this.lblSubditos.Size = new System.Drawing.Size(51, 13);
            this.lblSubditos.TabIndex = 4;
            this.lblSubditos.Text = "Subditos:";
            // 
            // txtGold
            // 
            this.txtGold.Location = new System.Drawing.Point(113, 27);
            this.txtGold.Name = "txtGold";
            this.txtGold.Size = new System.Drawing.Size(52, 20);
            this.txtGold.TabIndex = 0;
            this.txtGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblOro
            // 
            this.lblOro.AutoSize = true;
            this.lblOro.Location = new System.Drawing.Point(12, 30);
            this.lblOro.Name = "lblOro";
            this.lblOro.Size = new System.Drawing.Size(27, 13);
            this.lblOro.TabIndex = 0;
            this.lblOro.Text = "Oro:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmNuevaEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 279);
            this.Controls.Add(this.grbOtrasEstadisticas);
            this.Controls.Add(this.grbCriteriaEstadistica);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.grbCriteriaDatos);
            this.Name = "frmNuevaEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNuevaEstadistica_Load);
            this.grbCriteriaDatos.ResumeLayout(false);
            this.grbCriteriaDatos.PerformLayout();
            this.grbWinLost.ResumeLayout(false);
            this.grbWinLost.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.grbCriteriaEstadistica.ResumeLayout(false);
            this.grbCriteriaEstadistica.PerformLayout();
            this.grbOtrasEstadisticas.ResumeLayout(false);
            this.grbOtrasEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCriteriaDatos;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel tool_Save;
        private System.Windows.Forms.ToolStripLabel tool_Discard;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.Label lblInvocador;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.Label lblRonda;
        private System.Windows.Forms.GroupBox grbCriteriaEstadistica;
        private System.Windows.Forms.Label lblAsistencias;
        private System.Windows.Forms.Label lblMuertes;
        private System.Windows.Forms.Label lblAsesinatos;
        private System.Windows.Forms.ComboBox cboPartida;
        private System.Windows.Forms.ComboBox cboInvocador;
        private System.Windows.Forms.ComboBox cboRonda;
        private System.Windows.Forms.TextBox txtKDA;
        private System.Windows.Forms.Label lblDKA;
        private System.Windows.Forms.TextBox txtAssists;
        private System.Windows.Forms.TextBox txtDefeats;
        private System.Windows.Forms.TextBox txtKills;
        private System.Windows.Forms.GroupBox grbOtrasEstadisticas;
        private System.Windows.Forms.TextBox txtGold;
        private System.Windows.Forms.Label lblOro;
        private System.Windows.Forms.ComboBox cboCampeon;
        private System.Windows.Forms.Label lblCampeon;
        private System.Windows.Forms.TextBox txtMiniNeutral;
        private System.Windows.Forms.Label lblSubditosNeutrales;
        private System.Windows.Forms.TextBox txtMinions;
        private System.Windows.Forms.Label lblSubditos;
        private System.Windows.Forms.GroupBox grbWinLost;
        private System.Windows.Forms.RadioButton rdbLost;
        private System.Windows.Forms.RadioButton rdbWin;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}