﻿using Entity;
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
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            Vehiculo vehiculo = new Vehiculo();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}