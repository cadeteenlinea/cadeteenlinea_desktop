using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadeteEnLinea
{
    public partial class FormTareas : Form
    {
        public FormTareas()
        {
            InitializeComponent();
            dtmFecha.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dtmFecha.Value = this.getFechaActual();
            dtmHora.Value = this.getFechaActual();
        }

        private void FormTareas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cadeteenlineaDataSet.tarea' Puede moverla o quitarla según sea necesario.
            //this.tareaTableAdapter.Fill(this.cadeteenlineaDataSet.tarea);
            //dgvTareas.DataSource = tarea.getAllTareas();


            dgvTareas.AutoGenerateColumns = false;


            this.actualizarDgv();
            cmbProcesos.DataSource = proceso.getAllProcesos();
            cmbProcesos.ValueMember = "idproceso";
            cmbProcesos.DisplayMember = "nombre";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtmFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtmHora_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarea tablatarea = new tarea();
            
            tablatarea.fecha = dtmFecha.Value.Date;
            tablatarea.hora = new  TimeSpan(dtmHora.Value.Hour, dtmHora.Value.Minute, 0);
            tablatarea.estado = 1;
            tablatarea.proceso_idproceso = Convert.ToInt32(cmbProcesos.SelectedValue);
            if (tablatarea.insertar())
            {
                MessageBox.Show("Tarea Ingresada");
            }
            else {
                MessageBox.Show("No puede existir dos tareas en la misma hora");
            }
            this.actualizarDgv();
            hilo.reiniciarHilo();
        }

        private void actualizarDgv() {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = tarea.getAllTareas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private DateTime getFechaActual()
        {
            int anio, dia, mes;
            DateTime dtFecha;
            anio = DateTime.Today.Year;
            mes = DateTime.Today.Month;
            dia = DateTime.Today.Day;
            dtFecha = new DateTime(anio, mes, dia);
            return dtFecha;
        }

    }
}
