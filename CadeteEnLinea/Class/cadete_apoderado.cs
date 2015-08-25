using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;

namespace CadeteEnLinea
{
    public partial class cadete_apoderado
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            var json = "";
            var cadetes_apoderados = conexion.cadete_apoderado.Where(p => p.estado == estado).Select(p => new
            {
                idcadete_apoderado	 = p.idcadete_apoderado,
                cadete_rut = p.cadete_rut,
                apoderado_rut = p.apoderado_rut,
                tipoApoderado = p.tipoApoderado,
            }).ToList();

            string result = String.Empty;
            if (cadetes_apoderados.Count() != 0)
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                json = jss.Serialize(cadetes_apoderados);

                Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                result = webService.cadete_apoderado(json, estado.ToString());


                if (estado == 3)
                {
                    cadete_apoderado.deleteEstado(3);
                }
                else
                {
                    cadete_apoderado.changeEstado(estado, 0);
                }
                conexion.SaveChanges();
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            conexion.cadete_apoderado
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();
        }

        /********Elimina los registros que tengan el estado entregado**********/
        public static void deleteEstado(int estado)
        {
            var trans = conexion.cadete_apoderado.Where(p => p.estado == estado);
            foreach (var u in trans)
            {
                conexion.cadete_apoderado.Remove(u);
            }
            conexion.SaveChanges();
        }
    }
}
