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
                    ingles_tae.deleteEstado(3);
                }
                else
                {
                    ingles_tae.changeEstado(estado, 0);
                }
                conexion.SaveChanges();
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            conexion.ingles_tae
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();
        }

        /********Elimina los registros que tengan el estado entregado**********/
        public static void deleteEstado(int estado)
        {
            var trans = conexion.ingles_tae.Where(p => p.estado == estado);
            foreach (var u in trans)
            {
                conexion.ingles_tae.Remove(u);
            }
            conexion.SaveChanges();
        }

        /*******Ejecuta la secuencia de actualización de notas de ingles_tae*************/
        public static void actualizacionWeb()
        {
            usuario.actualizacionWeb();
            ingles_tae.sendWeb(1);
            ingles_tae.sendWeb(2);
            ingles_tae.sendWeb(3);
        }
    }
}
