using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InyeccionDependencias1.Bases
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
