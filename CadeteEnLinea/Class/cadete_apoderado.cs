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
            var cadete_apoderado = conexion.cadete_apoderado.Where(p => p.estado == estado).Select(p => new
            {
                idcadete_apoderado	 = p.idcadete_apoderado,
                cadete_rut = p.cadete_rut,
                apoderado_rut = p.apoderado_rut,
                tipoApoderado = p.tipoApoderado,
            }).ToList();

            string result = String.Empty;
            if (cadete_apoderado.Count() != 0)
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                json = jss.Serialize(cadete_apoderado);

                Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                result = webService.cadete_apoderado(json, estado.ToString());


                if (estado == 3)
                {
                    var trans = conexion.cadete_apoderado.Where(p => p.estado == estado);
                    foreach (var u in trans)
                    {
                        conexion.cadete_apoderado.Remove(u);
                    }
                }
                else
                {
                    conexion.cadete_apoderado
                        .Where(p => p.estado == estado)
                        .ToList()
                        .ForEach(p => p.estado = 0);
                }
                conexion.SaveChanges();
            }
            return result;
        }
    }
}
