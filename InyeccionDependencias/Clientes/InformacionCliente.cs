using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InyeccionDependencias.Clientes
{
    public class InformacionCliente : IInformacionCliente
    {
        public List<Cliente> ObtenerNombreClientePorId(int IdCliente)
        {
            try
            {
               List<Cliente> LstClientes = new List<Cliente>()
                {
                    new Cliente{Id=1, Nombre="Pedro"},
                    new Cliente{Id=2, Nombre="Pablo"},
                    new Cliente{Id=3, Nombre="Ricardo"},
                    new Cliente{Id=4, Nombre="Ivan"}
                };

                return LstClientes.Where(x => x.Id == IdCliente)
                    .Select(x => new Cliente() { Id = x.Id, Nombre = x.Nombre }).ToList();
            }
            catch (Exception err)
            {

                throw new ArgumentException(err.Message);
            }
        }
    }
}
