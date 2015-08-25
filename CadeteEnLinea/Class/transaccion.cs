using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;

namespace CadeteEnLinea
{
    public partial class transaccion
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            var json = "";
            var transacciones = conexion.transaccion.Where(p => p.estado == estado).Select(p => new
            {
                idtransaccion = p.idtransaccion,
                cadete_rut = p.cadete_rut,
                tipoTransaccion = p.tipoTransaccion,
                monto = p.monto,
                fechaMovimiento = p.fechaMovimiento,
                descripcion = p.descripcion,
                tipoCuenta = p.tipoCuenta,
            }).ToList();

            string result = String.Empty;
            if (transacciones.Count() != 0)
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                json = jss.Serialize(transacciones);

                Service_CadeteEnLinea.SiteControllerPortTypeClient webService = new SiteControllerPortTypeClient();
                result = webService.transacciones(json, estado.ToString());

                /******************************************************
                 *  actualización de estado o eliminación de registro
                 ******************************************************/
                if (estado == 3)
                {
                    var trans = conexion.transaccion.Where(p => p.estado == estado);
                    foreach (var u in trans)
                    {
                        conexion.transaccion.Remove(u);
                    }
                }
                else {
                    conexion.transaccion
                        .Where(p => p.estado == estado)
                        .ToList()
                        .ForEach(p => p.estado = 0);
                }

                /**********COMMIT*********/
                conexion.SaveChanges();
            }
            return result;
        }
    }
}
