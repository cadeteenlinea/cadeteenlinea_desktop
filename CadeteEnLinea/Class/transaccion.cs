using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CadeteEnLinea.Service_CadeteEnLinea;


/*se realiza cambio para actualizar los primeros registros enviados, esto es para evitar error de largo de string
 se envian de a 2000 registros*/
namespace CadeteEnLinea
{
    public partial class transaccion
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public static string sendWeb(int estado)
        {
            string result = String.Empty;
            while (transaccion.cantidad(estado) > 0)
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
                }).ToList().Take(2000);

                
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
                        transaccion.deleteEstado(3);
                    }
                    else
                    {
                        transaccion.changeEstado(estado, 0);
                    }
                    conexion.SaveChanges();
                }
            }
            return result;
        }

        /******Cambia de estado los registros, segun el actual y el despues*****/
        public static void changeEstado(int estadoActual, int estadoDespues)
        {
            var transacciones = conexion.transaccion.Where(p => p.estado == estadoActual).ToList().Take(2000);
            foreach (var u in transacciones)
            {
                u.estado = estadoDespues;
            }
            conexion.SaveChanges();
            /*conexion.transaccion
                .Where(p => p.estado == estadoActual)
                .ToList()
                .ForEach(p => p.estado = estadoDespues);
            conexion.SaveChanges();*/
        }

        /********Elimina los registros que tengan el estado entregado**********/
        public static void deleteEstado(int estado)
        {
            var trans = conexion.transaccion.Where(p => p.estado == estado);
            foreach (var u in trans)
            {
                conexion.transaccion.Remove(u);
            }
            conexion.SaveChanges();
        }

        /*******Ejecuta la secuencia de actualización de transacciones*************/
        public static void actualizacionWeb()
        {
            usuario.actualizacionWeb();
            errores.setErrors(transaccion.sendWeb(1));
            errores.setErrors(transaccion.sendWeb(2));
            errores.setErrors(transaccion.sendWeb(3));
        }

        /*entrega la cantidad de registros con el estado deseado*/
        public static int cantidad(int estado){
            var transacciones = conexion.transaccion.Where(p => p.estado == estado).ToList();
            return transacciones.Count();
        }
    }
}
