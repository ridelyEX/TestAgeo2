using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Proyectos
{
    public class ProyectosDto
    {
        public int Id { get; set; }
        public string Asunto { get; set; }
        public string Descripcion { get; set; }
        public string InformacionAdicional { get; set; }
        public string PuO { get; set; } // puesto u origen
        public string?  FotoUrl { get; set; }
        public string Folio { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public int CodigoPostal { get; set; }
    }
}
