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
    public partial class notas_fisico
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            string result = String.Empty;
            while (notas_fisico.cantidad(estado) > 0)
            {
                var json = "";
                var notas_fisicos = conexion.notas_fisico.Where(p => p.estado == estado).Select(p => new
                {
                    idnotas_fisico = p.idnotas_fisico,
                    cadete_rut = p.cadete.rut,
                    ano = p.ano,
                    semestre = p.semestre,
                    marca_100_mt = p.marca_100_mt,
                    marca_1000_mt = p.marca_1000_mt,
                    marca_salto_largo = p.marca_salto_largo,
                    marca_bala = p.marca_bala,
                    marca_100_libre = p.marca_100_libre,
                    marca_bajo_agua = p.marca_bajo_agua,
                    marca_trepa = p.marca_trepa,
                    marca_abdominales = p.marca_abdominales,
                    marca_extension_brazos = p.marca_extension_brazos,
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
                }).ToList().Take(1000);

                if (notas_fisicos.Count() != 0)
                {
                    JavaScriptSerializer jss = new JavaScriptSerializer();
                    json = jss.Serialize(notas_fisicos);

                    Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                    result = webService.notasFisicos(json, estado.ToString());


                    if (estado == 3)
                    {

                        notas_fisico.deleteEstado(3);
                    }
                    else
                    {
                        notas_fisico.changeEstado(estado, 0);
                    }
                    conexion.SaveChanges();
                }
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            var notas_fisicos = conexion.notas_fisico.Where(p => p.estado == estadoActual).ToList().Take(1000);
            foreach (var u in notas_fisicos)
            {
                u.estado = estadoDespues;
            }
            conexion.SaveChanges();

            /*conexion.notas_fisico
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();*/
        }

        /********Elimina los registros que tengan el estado entregado**********/
        public static void deleteEstado(int estado)
        {
            var trans = conexion.notas_fisico.Where(p => p.estado == estado);
            foreach (var u in trans)
            {
                conexion.notas_fisico.Remove(u);
            }
            conexion.SaveChanges();
        }

        /*******Ejecuta la secuencia de actualización de notas fisicas*************/
        public static void actualizacionWeb()
        {
            usuario.actualizacionWeb();
            errores.setErrors(notas_fisico.sendWeb(1));
            errores.setErrors(notas_fisico.sendWeb(2));
            errores.setErrors(notas_fisico.sendWeb(3));
            nivelacion.actualizacionWeb();
        }

        /*entrega la cantidad de registros con el estado deseado*/
        public static int cantidad(int estado)
        {
            var notas_fisicos = conexion.notas_fisico.Where(p => p.estado == estado).ToList();
            return notas_fisicos.Count();
        }
    }
}
