using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;


/*se realiza cambio para actualizar los primeros registros enviados, esto es para evitar error de largo de string
 se envian de a 1000 registros*/
namespace CadeteEnLinea
{
    public partial class notas_parciales
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            string result = String.Empty;
            while (notas_parciales.cantidad(estado) > 0)
            {
                var json = "";
                var notas_parcial = conexion.notas_parciales.Where(p => p.estado == estado).Select(p => new
                {
                    idnotas_parciales = p.idnotas_parciales,
                    nota = p.nota,
                    dia = p.dia,
                    mes = p.mes,
                    ano = p.ano,
                    semestre = p.semestre,
                    asignatura_idasignatura = p.asignatura.idasignatura,
                    cadete_rut = p.cadete.rut,
                    concepto = p.tipo
                }).ToList().Take(1000);

                if (notas_parcial.Count() != 0)
                {
                    JavaScriptSerializer jss = new JavaScriptSerializer();
                    json = jss.Serialize(notas_parcial);

                    Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                    result = webService.notasParciales(json, estado.ToString());

                    if (estado == 3)
                    {
                        notas_parciales.deleteEstado(3);
                    }
                    else
                    {
                        notas_parciales.changeEstado(estado, 0);
                    }

                    conexion.SaveChanges();
                }
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            var notas_parcial = conexion.notas_parciales.Where(p => p.estado == estadoActual).ToList().Take(1000);
            foreach (var u in notas_parcial)
            {
                u.estado = estadoDespues;
            }
            conexion.SaveChanges();

            /*conexion.notas_parciales
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();*/
        }

        /********Elimina los registros que tengan el estado entregado**********/
        public static void deleteEstado(int estado)
        {
            var trans = conexion.notas_parciales.Where(p => p.estado == estado);
            foreach (var u in trans)
            {
                conexion.notas_parciales.Remove(u);
            }
            conexion.SaveChanges();
        }

        /*******Ejecuta la secuencia de actualización de notas parciales*************/
        public static void actualizacionWeb()
        {
            usuario.actualizacionWeb();
            errores.setErrors(asignatura.sendWeb(1));
            errores.setErrors(asignatura.sendWeb(2));
            errores.setErrors(notas_parciales.sendWeb(1));
            errores.setErrors(notas_parciales.sendWeb(2));
            errores.setErrors(notas_parciales.sendWeb(3));
            errores.setErrors(notas_finales.sendWeb(3));
            errores.setErrors(asignatura.sendWeb(3));
        }

        /*entrega la cantidad de registros con el estado deseado*/
        public static int cantidad(int estado)
        {
            var notas_parcial = conexion.notas_parciales.Where(p => p.estado == estado).ToList();
            return notas_parcial.Count();
        }
    }
}
