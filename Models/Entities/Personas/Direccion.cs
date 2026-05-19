using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Personas
{
    public class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; } = string.Empty;
        public string Colonia { get; set; } = string.Empty;
        public int CodigoPostal { get; set; }
    }
}
