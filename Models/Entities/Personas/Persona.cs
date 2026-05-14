using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Personas
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Curp { get; set; } = string.Empty;
        public string Sexo { get; set; }
        public string Etnia { get; set; }
        public string GrupoVulnerable { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public Direccion Direccion { get; set; } = new Direccion();
        public Contacto Contacto { get; set; } = new Contacto();
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
