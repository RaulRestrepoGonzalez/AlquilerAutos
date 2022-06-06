using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoCliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public double ValorTotal { get; set; }

        public List<Persona> Personas { get; set; }

        public Persona(Vehiculo vehiculo)
        {
            Vehiculo = vehiculo;

        }

        public Persona() { }

        public string Escribir()
        {
            return $"{Id};{Nombre};{TipoCliente};{Vehiculo.Placa};{ValorTotal}";
        }

        public void Calcular()
        {
            switch (TipoCliente)
            {
                case "Ocacional":
                    ValorTotal = Vehiculo.KilometrajeActual + Vehiculo.ValorKM;
                    break;
                case "Contrato":
                    ValorTotal = Vehiculo.KilometrajeActual + (Vehiculo.ValorKM * 0.15);
                    break;
                default:
                    ValorTotal = 0.0;
                    break;
            }
        }
    }
}
