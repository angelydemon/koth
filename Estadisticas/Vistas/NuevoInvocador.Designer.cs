namespace Estadisticas.Vistas
{
    partial class frmNuevoInvocador
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
            this.txtNombreInvocador = new System.Windows.Forms.TextBox();
            this.lblNombreInvocador = new System.Windows.Forms.Label();
            this.grbCriteria = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
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
            // txtNombreInvocador
            // 
            this.txtNombreInvocador.Location = new System.Drawing.Point(138, 58);
            this.txtNombreInvocador.Name = "txtNombreInvocador";
            this.txtNombreInvocador.Size = new System.Drawing.Size(182, 20);
            this.txtNombreInvocador.TabIndex = 2;
            // 
            // lblNombreInvocador
            // 
            this.lblNombreInvocador.AutoSize = true;
            this.lblNombreInvocador.Location = new System.Drawing.Point(19, 61);
            this.lblNombreInvocador.Name = "lblNombreInvocador";
            this.lblNombreInvocador.Size = new System.Drawing.Size(113, 13);
            this.lblNombreInvocador.TabIndex = 2;
            this.lblNombreInvocador.Text = "Nombre de Invocador:";
            // 
            // grbCriteria
            // 
            this.grbCriteria.Controls.Add(this.btnGuardar);
            this.grbCriteria.Controls.Add(this.lblEmail);
            this.grbCriteria.Controls.Add(this.txtEmail);
            this.grbCriteria.Controls.Add(this.txtNombreInvocador);
            this.grbCriteria.Controls.Add(this.lblNombreInvocador);
            this.grbCriteria.Location = new System.Drawing.Point(12, 28);
            this.grbCriteria.Name = "grbCriteria";
            this.grbCriteria.Size = new System.Drawing.Size(341, 129);
            this.grbCriteria.TabIndex = 4;
            this.grbCriteria.TabStop = false;
            this.grbCriteria.Text = "Alta de Invocador";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(245, 91);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.tool_Save_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 1;
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
            this.toolStrip.Size = new System.Drawing.Size(381, 25);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tool_Save
            // 
            this.tool_Save.Name = "tool_Save";
            this.tool_Save.Size = new System.Drawing.Size(49, 22);
            this.tool_Save.Text = "&Guardar";
            this.tool_Save.Click += new System.EventHandler(this.tool_Save_Click);
            // 
            // tool_Discard
            // 
            this.tool_Discard.Name = "tool_Discard";
            this.tool_Discard.Size = new System.Drawing.Size(56, 22);
            this.tool_Discard.Text = "&Descartar";
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
            // frmNuevoInvocador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 202);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.grbCriteria);
            this.Name = "frmNuevoInvocador";
            this.Text = "Nuevo Invocador";
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

        private System.Windows.Forms.TextBox txtNombreInvocador;
        private System.Windows.Forms.Label lblNombreInvocador;
        private System.Windows.Forms.GroupBox grbCriteria;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel tool_Save;
        private System.Windows.Forms.ToolStripLabel tool_Discard;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}