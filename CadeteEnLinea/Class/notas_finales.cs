using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;


/*se realiza cambio para actualizar los primeros registros enviados, esto es para evitar error de largo de string
 se envian de a 3000 registros*/
namespace CadeteEnLinea
{
    public partial class notas_finales
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            string result = String.Empty;
            while (notas_finales.cantidad(estado) > 0)
            {
                var json = "";
                var notas_final = conexion.notas_finales.Where(p => p.estado_tf == estado).Select(p => new
                {
                    idnotas_finales = p.idnotas_finales,
                    nota_presentacion = p.nota_presentacion,
                    nota_examen = p.nota_examen,
                    nota_final = p.nota_final,
                    nota_examen_repeticion = p.nota_examen_repeticion,
                    nota_final_repeticion = p.nota_final_repeticion,
                    asignatura_idasignatura = p.asignatura.idasignatura,
                    estado = p.estado,
                    cadete_rut = p.cadete.rut,
                }).ToList().Take(3000);

                if (notas_final.Count() != 0)
                {
                    JavaScriptSerializer jss = new JavaScriptSerializer();
                    json = jss.Serialize(notas_final);

                    Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                    result = webService.notasFinales(json, estado.ToString());


                    if (estado == 3)
                    {
                        notas_finales.deleteEstado(3);
                    }
                    else
                    {
                        notas_finales.changeEstado(estado, 0);
                    }
                    conexion.SaveChanges();
                }
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            var notas_finales = conexion.notas_finales.Where(p => p.estado_tf == estadoActual).ToList().Take(3000);
            foreach (var u in notas_finales)
            {
                u.estado_tf = estadoDespues;
            }
            conexion.SaveChanges();
            /*conexion.notas_finales
                .Where(p => p.estado_tf == estadoActual)
                .ToList()
                .ForEach(p => p.estado_tf = estadoDespues);
            conexion.SaveChanges();*/
        }

        /********Elimina los registros que tengan el estado entregado**********/
        public static void deleteEstado(int estado)
        {
            var trans = conexion.notas_finales.Where(p => p.estado_tf == estado);
            foreach (var u in trans)
            {
                conexion.notas_finales.Remove(u);
            }
            conexion.SaveChanges();
        }

        /*******Ejecuta la secuencia de actualización de notas finales*************/
        public static void actualizacionWeb()
        {
            usuario.actualizacionWeb();
            errores.setErrors(asignatura.sendWeb(1));
            errores.setErrors(asignatura.sendWeb(2));
            errores.setErrors(notas_finales.sendWeb(1));
            errores.setErrors(notas_finales.sendWeb(2));
            errores.setErrors(notas_finales.sendWeb(3));
            errores.setErrors(notas_parciales.sendWeb(3));
            errores.setErrors(asignatura.sendWeb(3));
        }

        /*entrega la cantidad de registros con el estado deseado*/
        public static int cantidad(int estado)
        {
            var notas_final = conexion.notas_finales.Where(p => p.estado_tf == estado).ToList();
            return notas_final.Count();
        }
    }
}
