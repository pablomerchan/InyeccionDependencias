using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InyeccionDependencias.Clientes
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
