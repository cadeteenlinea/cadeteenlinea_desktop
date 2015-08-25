using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;


namespace CadeteEnLinea
{
    public partial class cadete
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            var json = "";
            var cadetes = conexion.cadete.Where(p => p.estado == estado).Select(p => new
            {
                rut = p.rut,
                nCadete = p.nCadete,
                direccion = "",
                comuna = "",
                ciudad = "",
                region = "",
                curso = p.curso,
                division = p.division,
                anoIngreso = p.anoIngreso,
                anoNacimiento = p.anoNacimiento,
                mesNacimiento = p.mesNacimiento,
                diaNacimiento = p.diaNacimiento,
                lugarNacimiento = p.lugarNacimiento,
                nacionalidad = p.nacionalidad,
                seleccion = p.seleccion,
                nivel = p.nivel,
                circulo = p.circulo,
                especialidad = p.especialidad,

            }).ToList();

            string result = String.Empty;
            if (cadetes.Count() != 0)
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                json = jss.Serialize(cadetes);

                Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                result = webService.cadetes(json, estado.ToString());

                if (estado == 3)
                {
                    cadete.deleteEstado(3);
                }
                else
                {
                    cadete.changeEstado(estado, 0);
                }
                conexion.SaveChanges();
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            conexion.cadete
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();
        }

        /********Elimina los registros que tengan el estado entregado**********/
        public static void deleteEstado(int estado)
        {
            var trans = conexion.cadete.Where(p => p.estado == estado);
            foreach (var u in trans)
            {
                conexion.cadete.Remove(u);
            }
            conexion.SaveChanges();
        }
    }
}
