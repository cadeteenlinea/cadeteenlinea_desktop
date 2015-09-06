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

        public static  void reiniciarHilo() {
            if (tarea.tareaEnEjecucion())
            {
                MessageBox.Show("en ejecución");
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

