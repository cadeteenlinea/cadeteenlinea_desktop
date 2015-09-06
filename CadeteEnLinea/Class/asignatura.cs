using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;

namespace CadeteEnLinea
{
    public partial class asignatura
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            var json = "";
            var asignaturas = conexion.asignatura.Where(p => p.estado == estado).Select(p => new
            {
                idasignatura = p.idasignatura,
                codigo = p.codigo,
                ano = p.ano,
                semestre = p.semestre,
                curso = p.curso,
                nombre = p.nombre,
                especialidad = p.especialidad,
            }).ToList();

            string result = String.Empty;
            if (asignaturas.Count() != 0)
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                json = jss.Serialize(asignaturas);

                Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                result = webService.asignaturas(json, estado.ToString());

                /******************************************************
                 *  actualización de estado o eliminación de registro
                 ******************************************************/
                if (estado == 3)
                {
                    asignatura.deleteEstado(3);
                }
                else
                {
                    asignatura.changeEstado(estado, 0);
                }
                conexion.SaveChanges();
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            conexion.asignatura
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();
        }

        /********Elimina los registros que tengan el estado entregado**********/
        public static void deleteEstado(int estado)
        {
            var trans = conexion.asignatura.Where(p => p.estado == estado);
            foreach (var u in trans)
            {
                conexion.asignatura.Remove(u);
            }
            conexion.SaveChanges();
        }

    }
}
