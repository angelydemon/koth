namespace Estadisticas.Vistas
{
    partial class frmNuevaRonda
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tool_Save = new System.Windows.Forms.ToolStripLabel();
            this.tool_Discard = new System.Windows.Forms.ToolStripLabel();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.grbCriteria = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblRonda = new System.Windows.Forms.Label();
            this.txtRonda = new System.Windows.Forms.TextBox();
            this.toolStrip.SuspendLayout();
            this.grbCriteria.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip.TabIndex = 6;
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
            // grbCriteria
            // 
            this.grbCriteria.Controls.Add(this.dtpFecha);
            this.grbCriteria.Controls.Add(this.lblFecha);
            this.grbCriteria.Controls.Add(this.lblRonda);
            this.grbCriteria.Controls.Add(this.txtRonda);
            this.grbCriteria.Location = new System.Drawing.Point(12, 28);
            this.grbCriteria.Name = "grbCriteria";
            this.grbCriteria.Size = new System.Drawing.Size(341, 129);
            this.grbCriteria.TabIndex = 7;
            this.grbCriteria.TabStop = false;
            this.grbCriteria.Text = "Nueva Ronda";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(138, 61);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(182, 20);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.Value = new System.DateTime(2015, 1, 22, 21, 16, 59, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(19, 64);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
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
            // txtRonda
            // 
            this.txtRonda.Location = new System.Drawing.Point(138, 35);
            this.txtRonda.Name = "txtRonda";
            this.txtRonda.Size = new System.Drawing.Size(182, 20);
            this.txtRonda.TabIndex = 0;
            // 
            // frmNuevaRonda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 167);
            this.Controls.Add(this.grbCriteria);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmNuevaRonda";
            this.Text = "Nueva Ronda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.grbCriteria.ResumeLayout(false);
            this.grbCriteria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel tool_Save;
        private System.Windows.Forms.ToolStripLabel tool_Discard;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.GroupBox grbCriteria;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblRonda;
        private System.Windows.Forms.TextBox txtRonda;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}