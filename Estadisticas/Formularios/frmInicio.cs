using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estadisticas.Formularios;

namespace Estadisticas.Formularios
{    

    public partial class frmInicio : Form
    {
        // Create the controls.
        //private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel panel1;
        private UserControl.ucInicio ucInicio;

        public frmInicio()
        {
            InitializeComponent();

            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            ucInicio = new UserControl.ucInicio();

            // Set the DockStyle of the UserControl to Fill.
            ucInicio.Dock = System.Windows.Forms.DockStyle.Fill;

            // Make the Panel the same size as the UserControl and give it a border.
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Size = ucInicio.Size;
            panel1.Location = new System.Drawing.Point(5, 5);

            // Add the user control to the Panel.
            panel1.Controls.Add(ucInicio);

            // Size the Form to accommodate the Panel.
            this.ClientSize = new System.Drawing.Size(
               panel1.Size.Width + 10, panel1.Size.Height + 10);
            this.Text = "Please enter the information below...";

            // Add the Panel to the Form.
            this.Controls.Add(panel1);
        }

        //[System.STAThreadAttribute()]
        //public static void Main()
        //{
        //    System.Windows.Forms.Application.Run(new frmInicio());
        //}
    }
}
