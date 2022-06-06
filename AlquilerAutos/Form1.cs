using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerAutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelMostrar.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                panelMostrar.Controls.Add(formulario);
                panelMostrar.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void btnPersona_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Cliente>();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmVehiculo>();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmFactura>();
        }
    }
}
