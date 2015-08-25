using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;

namespace CadeteEnLinea
{
    public partial class ingles_tae
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            var json = "";
            var ingles = conexion.ingles_tae.Where(p => p.estado == estado).Select(p => new
            {
                idingles_tae = p.idingles_tae,
                ano = p.ano,
                mes = p.mes,
                speaking = p.speaking,
                understanding = p.understanding,
                writing = p.writing,
                average = p.average,
                cadete_rut = p.cadete.rut,
            }).ToList();

            string result = String.Empty;
            if (ingles.Count() != 0)
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                json = jss.Serialize(ingles);

                Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                result = webService.ingles(json, estado.ToString());

                /******************************************************
                 *  actualización de estado o eliminación de registro
                 ******************************************************/
                if (estado == 3)
                {
                    var trans = conexion.ingles_tae.Where(p => p.estado == estado);
                    foreach (var u in trans)
                    {
                        conexion.ingles_tae.Remove(u);
                    }
                }
                else
                {
                    conexion.ingles_tae
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
