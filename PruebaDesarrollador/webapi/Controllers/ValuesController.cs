using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi.Context;
using webapi.Models;

namespace webapi.Controllers
{
    public class ValuesController : ApiController
    {
        
     
        public IHttpActionResult Get(string nombre)
        {
            try
            {
                UsuarioContext request = new UsuarioContext();
                var result = request.GetUser(nombre);

                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

       
       [HttpPost]
        public IHttpActionResult Post(UsuarioDto model)
        {
            try
            {
                UsuarioContext request = new UsuarioContext();
                var result = request.InsertUser(model.Nombre, model.Apellido, model.TipoDocumento, model.ValorGanar, model.EstadoCivil, model.FechaNacimiento.ToString());

                return Ok(result);
            }
            catch (Exception ex )
            {
                return BadRequest("error" + ex);
            }
           
        }

       
    }
}
