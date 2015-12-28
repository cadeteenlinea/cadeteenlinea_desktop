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
    public partial class nivelacion
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            string result = String.Empty;
            while (nivelacion.cantidad(estado) > 0)
            {
                var json = "";
                var nivelaciones = conexion.nivelacion.Where(p => p.estado == estado).Select(p => new
                {
                    idnivelacion = p.idnivelacion,
                    cadete_rut = p.cadete.rut,
                    ano = p.ano,
                    semestre = p.semestre,
                    etapa = p.etapa,
                    marca_100_mt = p.marca_100_mt,
                    marca_1000_mt = p.marca_1000_mt,
                    marca_salto_largo = p.marca_salto_largo,
                    marca_bala = p.marca_bala,
                    marca_100_libre = p.marca_100_libre,
                    marca_bajo_agua = p.marca_bajo_agua,
                    marca_trepa = p.marca_trepa,
                    marca_abdominales = p.marca_abdominales,
                    marca_extension_brazos = p.marca_extension_brazos,
                    marca_cooper = p.marca_cooper,
                    nota_100_mt = p.nota_100_mt,
                    nota_1000_mt = p.nota_1000_mt,
                    nota_salto_largo = p.nota_salto_largo,
                    nota_bala = p.nota_bala,
                    nota_100_libre = p.nota_100_libre,
                    nota_bajo_agua = p.nota_bajo_agua,
                    nota_trepa = p.nota_trepa,
                    nota_abdominales = p.nota_abdominales,
                    nota_extension_brazos = p.nota_extension_brazos,
                    nota_final = p.nota_final,
                    observacion = p.observacion,
                }).ToList().Take(1000);

                if (nivelaciones.Count() != 0)
                {
                    JavaScriptSerializer jss = new JavaScriptSerializer();
                    json = jss.Serialize(nivelaciones);

                    Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                    result = webService.nivelaciones(json, estado.ToString());

                    if (estado == 3)
                    {

                        nivelacion.deleteEstado(3);
                    }
                    else
                    {
                        nivelacion.changeEstado(estado, 0);
                    }
                    conexion.SaveChanges();
                }
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            var nivelaciones = conexion.nivelacion.Where(p => p.estado == estadoActual).ToList().Take(1000);
            foreach (var u in nivelaciones)
            {
                u.estado = estadoDespues;
            }
            conexion.SaveChanges();

            /*conexion.nivelacion
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();*/
        }

        /********Elimina los registros que tengan el estado entregado**********/
        public static void deleteEstado(int estado)
        {
            var trans = conexion.nivelacion.Where(p => p.estado == estado);
            foreach (var u in trans)
            {
                conexion.nivelacion.Remove(u);
            }
            conexion.SaveChanges();
        }

        /*******Ejecuta la secuencia de actualización de nivelacion*************/
        public static void actualizacionWeb()
        {
            errores.setErrors(nivelacion.sendWeb(1));
            errores.setErrors(nivelacion.sendWeb(2));
            errores.setErrors(nivelacion.sendWeb(3));
        }

        /*entrega la cantidad de registros con el estado deseado*/
        public static int cantidad(int estado)
        {
            var nivelaciones = conexion.nivelacion.Where(p => p.estado == estado).ToList();
            return nivelaciones.Count();
        }
    }
}