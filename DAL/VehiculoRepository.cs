using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VehiculoRepository
    {

        string ruta = "Vehiculo.txt";

        public void Guardar(Vehiculo vehiculo)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine(vehiculo.Escribir());
            escritor.Close();
            file.Close();
        }

        public List<Vehiculo> Consultar()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(file);
            string linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                Vehiculo vehiculo = MapearVehiculo(linea);
                vehiculos.Add(vehiculo);
            }
            lector.Close();
            file.Close();
            return vehiculos;
        }

        public void Eliminar(string Placa)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos.Clear();
            vehiculos = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in vehiculos)
            {
                if (item.Placa != Placa)
                {
                    Guardar(item);
                }
            }
        }

        public void Modificar(string Placa, List<Vehiculo> vehiculos)
        {
            vehiculos = new List<Vehiculo>();
            vehiculos.Clear();
            vehiculos = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in vehiculos)
            {
                if (item.Placa == Placa)
                {
                    item.ToString();
                    Guardar(item);
                }
                else
                {
                    Guardar(item);
                }
            }
        }

        public Vehiculo Buscar(string Placa)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos.Clear();
            vehiculos = Consultar();
            foreach (var item in vehiculos)
            {
                if (item.Placa.Equals(Placa))
                {
                    return item;
                }
            }
            return null;
        }

        private static Vehiculo MapearVehiculo(string linea)
        {
            string[] datosVehiculo = linea.Split(';');
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = datosVehiculo[0];
            vehiculo.Descripcion = datosVehiculo[1];
            vehiculo.KilometrajeActual = double.Parse(datosVehiculo[2]);
            vehiculo.Fecha = datosVehiculo[3];
            vehiculo.ValorKM = double.Parse(datosVehiculo[4]);
            return vehiculo;
        }

    }
}
