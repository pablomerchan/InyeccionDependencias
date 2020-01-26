using InyeccionDependencias1.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InyeccionDependencias.Clientes
{
    public class Cliente : Persona
    {
       public double ValorAFacturar { get; set; }
    }
}
