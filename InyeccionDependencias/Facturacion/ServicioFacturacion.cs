using InyeccionDependencias.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InyeccionDependencias.Facturacion
{
    public class ServicioFacturacion : IServicioFacturacion
    {
        public int ValorActualServicios(int IdCliente)
        {
            List<Cliente> LstClientes = new List<Cliente>()
            { 
                new Cliente { Id=1, ValorAFacturar=100},
                new Cliente { Id=2, ValorAFacturar=50},
                new Cliente { Id=3, ValorAFacturar=60},
                new Cliente { Id=4, ValorAFacturar=120},
                new Cliente { Id=5, ValorAFacturar=130},
                new Cliente { Id=6, ValorAFacturar=140},
                new Cliente { Id=7, ValorAFacturar=150},
                new Cliente { Id=8, ValorAFacturar=180}

            };

            var response = LstClientes.Where(x => x.Id == IdCliente)
                .Select(x=>x.ValorAFacturar).FirstOrDefault().ToString();

            return Convert.ToInt32(response);

        }
    }

}
