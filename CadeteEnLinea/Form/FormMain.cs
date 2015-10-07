using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CadeteEnLinea
{
    public partial class FormMain : Form
    {
        public static NotifyIcon icono; 

        public FormMain()
        {
            InitializeComponent();
        }

        private void ejecuciónManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcesoManual form = new FormProcesoManual();
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hilo.reiniciarHilo();
            Application.Exit();
        }

        private void fechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTareas form = new FormTareas();
            form.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tarea.icono = notifyIcon;
            notifyIcon.Visible = true;
            Hide();
            hilo.reiniciarHilo();

            // tmr = new Timer(tar.)

            //proceso.actualizacion(tar);
            //;
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState) {
                Hide();
                //notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            //notifyIcon.Visible = false;
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void mantenedorTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTareas form = new FormTareas();
            form.Show();
        }

    }
}
