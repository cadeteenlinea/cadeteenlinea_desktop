using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;

namespace CadeteEnLinea
{
    public partial class usuario
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();


        public static string sendWeb(int estado)
        {
            var json = "";
            var usuarios = conexion.usuario.Where(p => p.estado == estado).Select(p => new
            {
                rut = p.rut,
                apellidoPat = p.apellidoPat,
                apellidoMat = p.apellidoMat,
                nombre = p.nombre,
                password_2 = p.password_2,
                perfil = p.perfil,
            }).ToList();

            string result = String.Empty;
            if (usuarios.Count() != 0)
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                json = jss.Serialize(usuarios);

                Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                result = webService.usuarios(json, estado.ToString());


                if (estado == 3)
                {
                    usuario.deleteEstado(3);
                }
                else
                {
                    usuario.changeEstado(estado, 0);
                }
                
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues) {
            conexion.usuario
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();
        }

        /********Elimina los registros que tengan el estado entregado**********/
        public static void deleteEstado(int estado) {
            var trans = conexion.usuario.Where(p => p.estado == estado);
            foreach (var u in trans)
            {
                conexion.usuario.Remove(u);
            }
            conexion.SaveChanges();
        }

    }
}
