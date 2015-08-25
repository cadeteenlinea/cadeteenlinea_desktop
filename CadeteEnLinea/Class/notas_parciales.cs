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
            var notas_parciales = conexion.notas_parciales.Where(p => p.estado == estado).Select(p => new
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
            if (notas_parciales.Count() != 0)
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                json = jss.Serialize(notas_parciales);

                Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                result = webService.notasParciales(json, estado.ToString());


                if (estado == 3)
                {
                    var trans = conexion.notas_parciales.Where(p => p.estado == estado);
                    foreach (var u in trans)
                    {
                        conexion.notas_parciales.Remove(u);
                    }
                }
                else
                {
                    conexion.notas_parciales
                        .Where(p => p.estado == estado)
                        .ToList()
                        .ForEach(p => p.estado = 0);
                }

                conexion.SaveChanges();
            }
            return result;
        }
    }
}
