using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonaRepository
    {

        string ruta = "Personas.txt";

        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine(persona.Escribir());
            escritor.Close();
            file.Close();
        }

        public List<Persona> Consultar()
        {
            List<Persona> persona = new List<Persona>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(file);
            string linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                Persona personas = MapearPersona(linea);
                persona.Add(personas);
            }
            lector.Close();
            file.Close();
            return persona;
        }

        public void Eliminar(int Id)
        {
            List<Persona> personas = new List<Persona>();
            personas.Clear();
            personas = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in personas)
            {
                if (item.Id != Id)
                {
                    Guardar(item);
                }
            }
        }

        public void Modificar(int Id, List<Persona> personas)
        {
            personas = new List<Persona>();
            personas.Clear();
            personas = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in personas)
            {
                if (item.Id == Id)
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

        public Persona Buscar(int Id)
        {
            List<Persona> personas = new List<Persona>();
            personas.Clear();
            personas = Consultar();
            foreach (var item in personas)
            {
                if (item.Id.Equals(Id))
                {
                    return item;
                }
            }
            return null;
        }

        private static Persona MapearPersona(string linea)
        {
            string[] datosPersona = linea.Split(';');
            Persona persona = new Persona();
            Vehiculo vehiculo = new Vehiculo();
            persona.Id = int.Parse(datosPersona[0]);
            persona.Nombre = datosPersona[1];
            persona.TipoCliente = datosPersona[2];
            persona.ValorTotal = double.Parse(datosPersona[3]);
            persona.Vehiculo = vehiculo;
            return persona;
        }

    }
}
