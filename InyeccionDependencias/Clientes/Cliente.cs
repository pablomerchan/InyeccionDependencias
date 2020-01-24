using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDependencias.Clientes
{
    public class Cliente : ICliente
    {
        public string ObtenerNombreClientePorId(int IdCliente)
        {
            string response;
            List<string> LstClientes = new List<string>();

            LstClientes.Add("Pablo");
            LstClientes.Add("Allan");
            LstClientes.Add("Ivan");
            LstClientes.Add("Enrique");
            LstClientes.Add("Donald");

            
            throw new NotImplementedException();
        }
    }
}
