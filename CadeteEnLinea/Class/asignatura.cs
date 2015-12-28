using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;


/*se realiza cambio para actualizar los primeros registros enviados, esto es para evitar error de largo de string
 se envian de a 1500 registros*/
namespace CadeteEnLinea
{
    public partial class asignatura
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            string result = String.Empty;
            while (asignatura.cantidad(estado) > 0)
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
                }).ToList().Take(1500);

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
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            var asignaturas = conexion.asignatura.Where(p => p.estado == estadoActual).ToList().Take(1500);
            foreach (var u in asignaturas)
            {
                u.estado = estadoDespues;
            }
            conexion.SaveChanges();

            /*conexion.asignatura
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();*/
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

        /*entrega la cantidad de registros con el estado deseado*/
        public static int cantidad(int estado)
        {
            var asignaturas = conexion.asignatura.Where(p => p.estado == estado).ToList();
            return asignaturas.Count();
        }
    }
}
