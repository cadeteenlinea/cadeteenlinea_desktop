using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace CadeteEnLinea
{
    public partial class tarea
    {
        private static cadeteenlineaEntities conexion = new cadeteenlineaEntities();
        public static NotifyIcon icono = null;
        public static List<tarea> getAllTareas() {
            //var tar = conexion.tarea.Where(p => p.estado == 1).ToList();
            var tar = conexion.tarea.ToList();
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
            try
            {
                double sleep = this.diferenciaFecha();
                /*Instruccion para realizar el sleep para fechas muy grandes,
                 * ya que la isntruccion solo soporta
                 valores en integer*/
                while (sleep > 2147483647)
                {
                    sleep -= 2147483647;
                    Thread.Sleep(2147483647);
                }
                Thread.Sleep(Convert.ToInt32(sleep));

                string mensaje = "Se inicio la ejecución del proceso de actualización de " + this.proceso.nombre;
                string titulo = "Inicio de Proceso";
                this.mensajeEnPantalla(1, titulo, mensaje);

                //actualiza el estado de la tarea, para dejar constancia que se está ejecutando un proceso
                this.actualizarEstado(2);
                this.proceso.actualizacion();
            }
            catch (Exception e) {
                errores er = new errores();
                er.codigo = "-1";
                er.tarea_idTarea = this.idtarea;
                er.error = e.ToString();
                er.guardar();
            }
            //actualiza estado para identificar que la tarea se ejecuto, independiente si tubo errores.
            this.actualizarEstado(0);
            if (this.errores.Count() > 0)
            {
                string mensaje = "Finalizó la ejecución del proceso de actualización de " + this.proceso.nombre
                    + "\n" + "Cantidad de errores: " + this.errores.Count().ToString();
                string titulo = "Fin de Proceso";
                this.mensajeEnPantalla(2, titulo, mensaje);
            }
            else {
                string mensaje = "Finalizó exitosamente la ejecución del proceso de actualización de " + this.proceso.nombre;
                string titulo = "Fin de Proceso";
                this.mensajeEnPantalla(1, titulo, mensaje);
            }

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
        public static tarea tareaEnEjecucion() {
            var tar = conexion.tarea.Where(p => p.estado == 2).FirstOrDefault();
            if (tar == null) {
                return null;
            }
            return tar;
        }

        public bool insertar() {
            if (this.validarHora())
            {
                conexion.tarea.Add(this);
                conexion.SaveChanges();
                
                this.proceso = proceso.buscar(this.proceso_idproceso);
                return true;
            }
            else {
                return false;
            }
        }

        private bool validarHora() {
            var tarea = conexion.tarea.Where(p => p.fecha == this.fecha && p.hora == this.hora && p.estado == 1).FirstOrDefault();
            if (tarea != null)
            {
                return false;
            }
            else { 
                return true;
            }
        }

        /*despliega mensaje por pantalla (burbuja) indicando el estado de la tarea*/
        public void mensajeEnPantalla(int estado,string titulo, string mensaje) {
            tarea.icono.BalloonTipTitle = titulo;
            tarea.icono.BalloonTipText = mensaje;
            switch (estado) {
                // para burbuja sin formato
                case 0:
                    tarea.icono.BalloonTipIcon = ToolTipIcon.None;
                    break;
                //para burbuja de info
                case 1:
                    tarea.icono.BalloonTipIcon = ToolTipIcon.Info;
                    break;
                //para burbuja de error
                case 2:
                    tarea.icono.BalloonTipIcon = ToolTipIcon.Error;
                    break;
                //para burbuja de warning
                case 3:
                    tarea.icono.BalloonTipIcon = ToolTipIcon.Warning;
                    break;
            }
            tarea.icono.ShowBalloonTip(7000);
        }
    }
}
