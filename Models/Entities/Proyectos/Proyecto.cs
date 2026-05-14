using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Proyectos
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Asunto { get; set; }
        public DireccionProyecto Direccion { get; set; }
        public string Descripcion { get; set; }
        public string InformacionAdicional { get; set; }
        /// <summary>
        /// Hace referencia al puesto u origen de la solicitud/solicitante
        /// </summary>
        public string PuO { get; set; } // puesto u origen
        public string? FotoUrl { get; set; }
        public string Folio { get; set; }
        public DateOnly FechaCreacion { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
