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
    public partial class frmVehiculo : Form
    {
        VehiculoService vehiculoService = new VehiculoService();

        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();

            vehiculo.Placa = txtbPlaca.Text;
            vehiculo.Descripcion = txtbDescripcion.Text;
            vehiculo.KilometrajeActual = double.Parse(textBoxKilometraje.Text);
            vehiculo.ValorKM = double.Parse(txtbValorKilo.Text);
            vehiculo.Fecha = dateTimeFecha.Text;
            string mensaje = vehiculoService.Guardar(vehiculo);
            MessageBox.Show(mensaje);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dtgVehiculo.DataSource = null;
            dtgVehiculo.DataSource = vehiculoService.Consultar().Vehiculos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculoService.Eliminar(vehiculo.Placa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
