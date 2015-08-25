using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;

namespace CadeteEnLinea
{
    public partial class notas_parciales
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
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
            }).ToList();

            string result = String.Empty;
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
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            conexion.notas_parciales
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();
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
    }
}
