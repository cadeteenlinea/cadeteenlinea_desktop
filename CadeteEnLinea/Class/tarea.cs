using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Threading;

namespace CadeteEnLinea
{
    public partial class tarea
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();
        
        public static List<tarea> getAllTareas() {
            var tar = conexion.tarea.Where(p => p.estado == 1).ToList();
            return tar;
        }

        /* retorna la proxima tarea a realizar
         * ordena por fecha y luego hora*/
        public static tarea getProximaTarea() {
            var tar = conexion.tarea.Where(p => p.estado == 1).OrderBy(p => p.fecha).ThenBy(p => p.hora).FirstOrDefault();
            if (tar == null) {
                return null;
            }
            return tar;
        }

        public void ejecutarTarea() {
            double sleep = this.diferenciaFecha();
            /*Instruccion para realizar el sleep para fechas muy grandes,
             * ya que la isntruccion solo soporta
             valores en integer*/
            while (sleep > 2147483647) {
                sleep -= 2147483647;
                Thread.Sleep(2147483647);
            }
            Thread.Sleep(Convert.ToInt32(sleep));
            
            //actualiza el estado de la tarea, para dejar constancia que se está ejecutando un proceso
            this.actualizarEstado(2);
            this.proceso.actualizacion();
            //actualiza estado para identificar que la tarea se ejecuto, independiente si tubo errores.
            this.actualizarEstado(0);
            //se llama nuevamente al proceso de reiniciarHilo, para poder instanciar una nueva tarea
            hilo.reiniciarHilo();
        }

        private void actualizarEstado(int estado) {
            conexion.tarea
                .Where(p => p.idtarea == this.idtarea)
                .ToList()
                .ForEach(p => p.estado = estado);
            conexion.SaveChanges();
        }

        /*metodo para establecer la diferencia de tiempo entre la hora 
         * de ejecución de la tarea con la fecha y hora actual*/
        private double diferenciaFecha() {
            DateTime now = DateTime.Now;
            DateTime fecha = Convert.ToDateTime(this.fecha + this.hora);
            if (fecha < now)
            {
                return 0;
            }
            else {
                TimeSpan t = fecha - now;
                double milisegundos = t.TotalMilliseconds;
                return milisegundos;
            }
        }

        /*retorna respuesta de acuerdo a si existe una tarea en ejecución, estado = 2
          true = tarea en ejecución, false = no hay tarea en ejecución*/
        public static bool tareaEnEjecucion() {
            var tar = conexion.tarea.Where(p => p.estado == 2).FirstOrDefault();
            if (tar == null) {
                return false;
            }
            return true;
        }

        public void insertar() {
            conexion.tarea.Add(this);
            conexion.SaveChanges();
        }
    }
}
