using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CadeteEnLinea
{
    public partial class proceso
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();
        
        private etl etl;

        public static List<proceso> getAllProcesos()
        {
            var procesos = conexion.proceso.ToList();
            return procesos;
        }

        /*Proceso de actualización de registros, el proceso seleccionado*/
        public void actualizacion(){
            this.etl = new etl(this);
            if (this.etl.ejecutar() == true)
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
                    case 7:
                        notas_fisico.actualizacionWeb();
                        break;
                }
            }
            
        }

        public static proceso buscar(int idproceso) {
            var proceso = conexion.proceso.Where(p => p.idproceso == idproceso).FirstOrDefault();
            return proceso;
        }
    }
}
