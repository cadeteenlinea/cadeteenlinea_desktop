using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;

namespace CadeteEnLinea
{
    public partial class apoderado
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            var json = "";
            var apoderados = conexion.apoderado.Where(p => p.estado == estado).Select(p => new
            {
                rut = p.rut,
                direccion = p.direccion,
                comuna = p.comuna,
                ciudad = p.ciudad,
                region = "",
                fono = p.fono,
                fonoComercial = p.fonoComercial,
                difunto = p.difunto,

            }).ToList();

            string result = String.Empty;
            if (apoderados.Count() != 0)
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                json = jss.Serialize(apoderados);

                Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                result = webService.apoderados(json, estado.ToString());


                if (estado == 3)
                {
                    var trans = conexion.apoderado.Where(p => p.estado == estado);
                    foreach (var u in trans)
                    {
                        conexion.apoderado.Remove(u);
                    }
                }
                else
                {
                    conexion.apoderado
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
