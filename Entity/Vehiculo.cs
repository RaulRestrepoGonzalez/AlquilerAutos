using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Descripcion { get; set; }
        public double KilometrajeActual { get; set; }
        public string Fecha { get; set; }
        public double ValorKM { get; set; }

        public List<Vehiculo> Vehiculos { get; set; }

        public Vehiculo() { }

        public string Escribir()
        {
            return $"{Placa};{Descripcion};{KilometrajeActual};{Fecha};{ValorKM}";
        }
    }
}
