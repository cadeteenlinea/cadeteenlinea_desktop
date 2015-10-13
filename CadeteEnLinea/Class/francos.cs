using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;

namespace CadeteEnLinea
{
    public partial class francos
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        /* OBSERVACIÓN: los francos se reinician cada vez que se ejecuta la ETL
         * por esto mismo, solo se ejecuta el sendWeb de estados en 1
         */
        public static string sendWeb(int estado)
        {
            var json = "";
            var salidas = conexion.francos.Where(p => p.estado == estado).Select(p => new
            {
                idfrancos = p.idfrancos,
                cadete_rut = p.cadete.rut,
                fecha_salida = p.fecha_salida,
                hora_salida = p.hora_salida,
                fecha_recogida = p.fecha_recogida,
                hora_recogida = p.hora_recogida,
                asignatura_bajo = p.asignatura_bajo,
            }).ToList();

            string result = String.Empty;
            if (salidas.Count() != 0)
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                json = jss.Serialize(salidas);

                Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                result = webService.francos(json, estado.ToString());


                if (estado == 3)
                {

                    francos.deleteEstado(3);
                }
                else
                {
                    francos.changeEstado(estado, 0);
                }
                conexion.SaveChanges();
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            conexion.francos
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();
        }

        /********Elimina los registros que tengan el estado entregado**********/
        public static void deleteEstado(int estado)
        {
            var trans = conexion.francos.Where(p => p.estado == estado);
            foreach (var u in trans)
            {
                conexion.francos.Remove(u);
            }
            conexion.SaveChanges();
        }

        /*******Ejecuta la secuencia de actualización de francos*************/
        public static void actualizacionWeb()
        {
            usuario.actualizacionWeb();
            errores.setErrors(francos.sendWeb(1));
        }
    }
}
