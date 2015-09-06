using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CadeteEnLinea
{
    public partial class proceso
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();
        public static NotifyIcon icono = null;
        public static List<proceso> getAllProcesos()
        {
            var procesos = conexion.proceso.ToList();
            return procesos;
        }

        public void actualizacion(){
            proceso.icono.BalloonTipTitle = "Inicio de Proceso";
            proceso.icono.BalloonTipText = "Se inicio la ejecución del proceso de actualización de " + this.nombre;
            proceso.icono.BalloonTipIcon = ToolTipIcon.Info;
            proceso.icono.ShowBalloonTip(7000);

            etl e = new etl(this);
            if (e.ejecutar() == true)
            {
                switch (this.idproceso)
                {
                    case 1:
                        usuario.actualizacionWeb();
                        break;
                    case 2:
                        notas_parciales.actualizacionWeb();
                        break;
                    case 3:
                        calificaciones.actualizacionWeb();
                        break;
                    case 4:
                        ingles_tae.actualizacionWeb();
                        break;
                    case 5:
                        transaccion.actualizacionWeb();
                        break;
                    case 6:
                        notas_finales.actualizacionWeb();
                        break;
                }
            }
            proceso.icono.BalloonTipTitle = "Fin de Proceso";
            proceso.icono.BalloonTipText = "Finalizó la ejecución del proceso de actualización de " + this.nombre;
            proceso.icono.BalloonTipIcon = ToolTipIcon.Info;
            proceso.icono.ShowBalloonTip(7000);
        }

    }
}
