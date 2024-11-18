using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Models
{
   
    public class UsuarioDto
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public int TipoDocumento { set; get; }

        public int ValorGanar { set; get; }
        public int EstadoCivil { set; get; }


        public string FechaNacimiento { set; get; }

    }
}