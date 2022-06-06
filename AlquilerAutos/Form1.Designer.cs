namespace AlquilerAutos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMostrar = new System.Windows.Forms.Panel();
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(214)))), ((int)(((byte)(137)))));
            this.panel1.Controls.Add(this.btnFactura);
            this.panel1.Controls.Add(this.btnVehiculo);
            this.panel1.Controls.Add(this.btnPersona);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 621);
            this.panel1.TabIndex = 0;
            // 
            // panelMostrar
            // 
            this.panelMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(170)))), ((int)(((byte)(234)))));
            this.panelMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMostrar.Location = new System.Drawing.Point(200, 0);
            this.panelMostrar.Name = "panelMostrar";
            this.panelMostrar.Size = new System.Drawing.Size(1151, 621);
            this.panelMostrar.TabIndex = 1;
            // 
            // btnPersona
            // 
            this.btnPersona.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersona.FlatAppearance.BorderSize = 0;
            this.btnPersona.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersona.Location = new System.Drawing.Point(0, 0);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(200, 75);
            this.btnPersona.TabIndex = 0;
            this.btnPersona.Text = "Registrar cliente";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiculo.FlatAppearance.BorderSize = 0;
            this.btnVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVehiculo.Location = new System.Drawing.Point(0, 75);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(200, 77);
            this.btnVehiculo.TabIndex = 1;
            this.btnVehiculo.Text = "Registrar vehiculo";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFactura.Location = new System.Drawing.Point(0, 152);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(200, 73);
            this.btnFactura.TabIndex = 2;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 621);
            this.Controls.Add(this.panelMostrar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMostrar;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnFactura;
    }
}

