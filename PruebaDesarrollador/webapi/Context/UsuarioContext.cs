using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using webapi.Models;

namespace webapi.Context
{
    public class UsuarioContext  
    {
        public TESTEntities dbo = new TESTEntities();
        internal string InsertUser(string nombre, string apellido, int tipoc, decimal valor, int estadocivil, string fecha) 
        {
            try
            {

           
                 var resp =  dbo.SP_insertUsuario(nombre, apellido, tipoc, valor, estadocivil, fecha);
                return resp.FirstOrDefault().codigo;
            }
            catch (Exception ec)
            {

                throw ec;
            }
        }

        internal SP_getUser_Result GetUser(string nombre)
        {
            try
            {

                var resp = dbo.SP_getUser(nombre).FirstOrDefault();
                return resp;
            }
            catch (Exception ec)
            {

                throw ec;
            }
        }
    }
}