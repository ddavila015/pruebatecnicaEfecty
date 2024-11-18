using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.Models
{
    public class UsuarioDto
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public int TipoDocumento { set; get; }

        public int ValorGanar { set; get; }
        public int EstadoCivil { set; get; }


        public DateTime FechaNacimiento { set; get; }

    }

    public class TipoDocumentosDto
    {
        public string Nombre { set; get; }
        public int Id { set; get; } 
    }
}
