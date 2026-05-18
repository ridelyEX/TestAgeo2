using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Personas
{
    public class PersonasDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidioPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Curp { get; set; } = string.Empty;
        public string Sexo { get; set; }
        public string Etnia { get; set; }
        public string GrupoVulnerable { get; set; }
        public DateOnly FechaNacimiento { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public string Calle { get; set; } = string.Empty;
        public string Colonia { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
        public string NumeroTelefono { get; set; } = string.Empty;

    }
}
