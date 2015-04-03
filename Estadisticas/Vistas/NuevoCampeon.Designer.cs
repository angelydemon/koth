namespace Estadisticas.Vistas
{
    partial class frmNuevoCampeon
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
            this.lblCampeon = new System.Windows.Forms.Label();
            this.txtCampeon = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tool_Save = new System.Windows.Forms.ToolStripLabel();
            this.tool_Discard = new System.Windows.Forms.ToolStripLabel();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbCriteria.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCriteria
            // 
            this.grbCriteria.Controls.Add(this.lblCampeon);
            this.grbCriteria.Controls.Add(this.txtCampeon);
            this.grbCriteria.Location = new System.Drawing.Point(12, 31);
            this.grbCriteria.Name = "grbCriteria";
            this.grbCriteria.Size = new System.Drawing.Size(341, 80);
            this.grbCriteria.TabIndex = 8;
            this.grbCriteria.TabStop = false;
            this.grbCriteria.Text = "Nuevo Campeón";
            // 
            // lblCampeon
            // 
            this.lblCampeon.AutoSize = true;
            this.lblCampeon.Location = new System.Drawing.Point(19, 38);
            this.lblCampeon.Name = "lblCampeon";
            this.lblCampeon.Size = new System.Drawing.Size(94, 13);
            this.lblCampeon.TabIndex = 0;
            this.lblCampeon.Text = "Nombre campeón:";
            // 
            // txtCampeon
            // 
            this.txtCampeon.Location = new System.Drawing.Point(138, 35);
            this.txtCampeon.Name = "txtCampeon";
            this.txtCampeon.Size = new System.Drawing.Size(182, 20);
            this.txtCampeon.TabIndex = 0;
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
            this.toolStrip.Size = new System.Drawing.Size(368, 25);
            this.toolStrip.TabIndex = 9;
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
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmNuevoCampeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 145);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.grbCriteria);
            this.Name = "frmNuevoCampeon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Campeon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbCriteria.ResumeLayout(false);
            this.grbCriteria.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCriteria;
        private System.Windows.Forms.Label lblCampeon;
        private System.Windows.Forms.TextBox txtCampeon;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel tool_Save;
        private System.Windows.Forms.ToolStripLabel tool_Discard;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}