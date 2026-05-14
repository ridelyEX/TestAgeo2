using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Personas
{
    public class Contacto
    {
        public int Id { get; set; }
        [Phone]
        public string NumeroTelefono { get; set; } = string.Empty;
    }
}
