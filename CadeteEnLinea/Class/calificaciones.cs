using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;

namespace CadeteEnLinea
{
    public partial class calificaciones
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            var json = "";
            var calificacion = conexion.calificaciones.Where(p => p.estado == estado).Select(p => new
            {
                idcalificaciones = p.idcalificaciones,
                ano = p.ano,
                semestre = p.semestre,
                mando = p.mando,
                interes_profesional = p.interes_profesional,
                personalidad_madurez = p.personalidad_madurez,
                responsabilidad = p.responsabilidad,
                espiritu_militar = p.espiritu_militar,
                cooperacion = p.cooperacion,
                conducta = p.conducta,
                aptitud_fisica = p.aptitud_fisica,
                tenida_orden_aseo = p.tenida_orden_aseo,
                final = p.final,
                cadete_rut = p.cadete.rut,
            }).ToList();

            string result = String.Empty;
            if (calificacion.Count() != 0)
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                json = jss.Serialize(calificacion);

                Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                result = webService.calificaciones(json, estado.ToString());

                if (estado == 3)
                {
                    calificaciones.deleteEstado(3);
                }
                else
                {
                    calificaciones.changeEstado(estado, 0);
                }
                conexion.SaveChanges();
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            conexion.calificaciones
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();
        }

        /********Elimina los registros que tengan el estado entregado**********/
        public static void deleteEstado(int estado)
        {
            var trans = conexion.calificaciones.Where(p => p.estado == estado);
            foreach (var u in trans)
            {
                conexion.calificaciones.Remove(u);
            }
            conexion.SaveChanges();
        }

        /*******Ejecuta la secuencia de actualización de calificaciones*************/
        public static void actualizacionWeb()
        {
            usuario.actualizacionWeb();
            calificaciones.sendWeb(1);
            calificaciones.sendWeb(2);
            calificaciones.sendWeb(3);
        }
    }
}
