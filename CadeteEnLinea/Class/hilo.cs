using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadeteEnLinea
{
    public static class hilo
    {
        static Thread Ejecutar = null;

        /*instancia y establece el hilo con su tarea a realizar
            si existe una tarea en ejecución, se espera 1 min para volver a consultar
         */
        public static  void reiniciarHilo() {
            if (tarea.tareaEnEjecucion() != null)
            {
                //MessageBox.Show("Exisste una tarea en ejecución");
                Thread.Sleep(60000);
                hilo.reiniciarHilo();
            }
            else
            {
                Ejecutar = null;
                tarea tar = tarea.getProximaTarea();
                if (tar != null)
                {
                    Ejecutar = new Thread(() => tar.ejecutarTarea());
                    Ejecutar.Start();
                }
            }
        }
    }
}

