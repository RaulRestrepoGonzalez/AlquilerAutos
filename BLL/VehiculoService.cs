using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VehiculoService
    {

        VehiculoRepository vehiculoRepository;
        public VehiculoService()
        {
            vehiculoRepository = new VehiculoRepository();
        }

        public string Guardar(Vehiculo vehiculo)
        {
            try
            {
                if (BuscarPorPlaca(vehiculo.Placa) == null)
                {
                    vehiculoRepository.Guardar(vehiculo);
                    return "Datos Guardados Satisfactoriamente";
                }
                return $"El vehiculo con la placa {vehiculo.Placa} ya se encuentra registrada";

            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error:" + exception.Message;
            }
        }

        public Vehiculo BuscarPorPlaca(string Placa)
        {

            foreach (var item in Consultar().Vehiculos)
            {
                if (item.Placa.Equals(Placa))
                {
                    return item;
                }
            }
            return null;
        }

        public ConsultaResponse Consultar()
        {
            ConsultaResponse response;

            try
            {
                response = new ConsultaResponse(vehiculoRepository.Consultar());
                return response;
            }
            catch (Exception exception)
            {
                response = new ConsultaResponse("Se presentó el siguiente error:" + exception.Message);
                response.Vehiculos = null;
                return response;
            }

        }

        public string Eliminar(string Placa)
        {
            try
            {
                if (vehiculoRepository.Buscar(Placa) != null)
                {
                    vehiculoRepository.Eliminar(Placa);
                    return $"se elimino la placa numero: {Placa} correctamente";
                }
                return $"El numero de placa no esta registrado en el sistema";
            }
            catch (Exception e)
            {
                return $"ERROR" + e.Message;
            }
        }

        public string Modificar(string Placa, List<Vehiculo> vehiculos)
        {
            try
            {
                if (vehiculoRepository.Buscar(Placa) != null)
                {
                    vehiculoRepository.Modificar(Placa, vehiculos);
                    return $"la placa numero: {Placa} ha sido modificada con exito!";

                }
                return $"El numero de placa: {Placa} no se encuentra registrada por favor verifique los datos";

            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }
        }

        public class ConsultaResponse
        {
            public List<Vehiculo> Vehiculos { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public ConsultaResponse(List<Vehiculo> vehiculos)
            {
                Vehiculos = vehiculos;
                Error = false;
            }

            public ConsultaResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }

        }

    }
}
