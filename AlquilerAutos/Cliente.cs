using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AlquilerAutos
{
    public partial class Cliente : Form
    {

        PersonaService personaService = new PersonaService();

        public Cliente()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Id = int.Parse(textBoxId.Text);
            persona.Nombre = textBoxNombre.Text;
            persona.TipoCliente = comboBox1.Text;
            persona.Calcular();
            string mensaje = personaService.Guardar(persona);
            MessageBox.Show(mensaje);
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            dtgCliente.DataSource = null;
            dtgCliente.DataSource = personaService.Consultar().Personas;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            personaService.Eliminar(persona.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
