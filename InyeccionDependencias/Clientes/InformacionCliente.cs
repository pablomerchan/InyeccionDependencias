using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InyeccionDependencias.Clientes
{
    public class InformacionCliente : IInformacionCliente
    {
        public string ObtenerNombrePorId(int IdCliente)
        {
            string response;
            try
            {
               List<Cliente> LstClientes = new List<Cliente>()
                {
                    new Cliente{Id=1, Nombre="Pedro"},
                    new Cliente{Id=2, Nombre="Pablo"},
                    new Cliente{Id=3, Nombre="Pascual"},
                    new Cliente{Id=4, Nombre="Pilar"}
                };

                 response= LstClientes.Where(x => x.Id == IdCliente).FirstOrDefault().Nombre;

                return response;


            }
            catch (Exception err)
            {

                throw new ArgumentException(err.Message);
            }
        }
    }
}
