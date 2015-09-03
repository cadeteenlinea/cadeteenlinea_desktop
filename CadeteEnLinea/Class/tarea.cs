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

        public static tarea getProximaTarea() {
            var tar = conexion.tarea.Where(p => p.estado == 1).OrderBy(p => p.fecha).FirstOrDefault();
            if (tar == null) {
                return null;
            }
            return tar;
        }

        public void ejecutarTarea() {
            //tarea tar = tarea.getProximaTarea();
            double sleep = this.diferenciaFecha();
            Thread.Sleep(Convert.ToInt32(sleep));
            this.actualizarEstado(2);
            this.proceso.actualizacion();
            this.actualizarEstado(0);
            hilo.reiniciarHilo();
        }

        private void actualizarEstado(int estado) {
            conexion.tarea
                .Where(p => p.idtarea == this.idtarea)
                .ToList()
                .ForEach(p => p.estado = estado);
            conexion.SaveChanges();
        }

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

        public static bool tareaEnEjecucion() {
            var tar = conexion.tarea.Where(p => p.estado == 2).FirstOrDefault();
            if (tar == null) {
                return false;
            }
            return true;
        }
    }
}
