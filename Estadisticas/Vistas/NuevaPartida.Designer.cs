namespace Estadisticas.Vistas
{
    partial class frmNuevaPartida
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
            this.grbCriteria = new System.Windows.Forms.GroupBox();
            this.txtPartida = new System.Windows.Forms.TextBox();
            this.cboRonda = new System.Windows.Forms.ComboBox();
            this.lblPartida = new System.Windows.Forms.Label();
            this.lblRonda = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tool_Save = new System.Windows.Forms.ToolStripLabel();
            this.tool_Discard = new System.Windows.Forms.ToolStripLabel();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.grbCriteria.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCriteria
            // 
            this.grbCriteria.Controls.Add(this.txtPartida);
            this.grbCriteria.Controls.Add(this.cboRonda);
            this.grbCriteria.Controls.Add(this.lblPartida);
            this.grbCriteria.Controls.Add(this.lblRonda);
            this.grbCriteria.Location = new System.Drawing.Point(12, 28);
            this.grbCriteria.Name = "grbCriteria";
            this.grbCriteria.Size = new System.Drawing.Size(341, 129);
            this.grbCriteria.TabIndex = 8;
            this.grbCriteria.TabStop = false;
            this.grbCriteria.Text = "Ronda";
            // 
            // txtPartida
            // 
            this.txtPartida.Location = new System.Drawing.Point(138, 64);
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Size = new System.Drawing.Size(121, 20);
            this.txtPartida.TabIndex = 2;
            // 
            // cboRonda
            // 
            this.cboRonda.FormattingEnabled = true;
            this.cboRonda.Location = new System.Drawing.Point(138, 34);
            this.cboRonda.Name = "cboRonda";
            this.cboRonda.Size = new System.Drawing.Size(121, 21);
            this.cboRonda.TabIndex = 0;
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Location = new System.Drawing.Point(21, 67);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(40, 13);
            this.lblPartida.TabIndex = 4;
            this.lblPartida.Text = "Partida";
            // 
            // lblRonda
            // 
            this.lblRonda.AutoSize = true;
            this.lblRonda.Location = new System.Drawing.Point(19, 38);
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
            this.toolStrip.Size = new System.Drawing.Size(365, 25);
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
            // frmNuevaPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 167);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.grbCriteria);
            this.Name = "frmNuevaPartida";
            this.Text = "Nueva Partida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNuevaPartida_Load);
            this.grbCriteria.ResumeLayout(false);
            this.grbCriteria.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCriteria;
        private System.Windows.Forms.Label lblRonda;
        private System.Windows.Forms.ComboBox cboRonda;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel tool_Save;
        private System.Windows.Forms.ToolStripLabel tool_Discard;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.TextBox txtPartida;
        private System.Windows.Forms.Label lblPartida;
    }
}