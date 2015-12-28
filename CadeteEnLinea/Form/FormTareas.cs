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
        int indexTarea = -1;
        public FormTareas()
        {
            InitializeComponent();
            dtmFecha.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dtmFecha.Value = DateTime.Now;
            this.establecerHora(DateTime.Now);
            timer.Start();
        }

        private void FormTareas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cadeteenlineaDataSet.tarea' Puede moverla o quitarla según sea necesario.
            // this.tareaTableAdapter.Fill(this.cadeteenlineaDataSet.tarea);
            // dgvTareas.DataSource = tarea.getAllTareas();

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
            int segundos = dtmHora.Value.Second;
            if (segundos > 0)
            {
                DateTime fecha = Convert.ToDateTime(dtmHora.Value);
                this.establecerHora(fecha);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarea tablatarea = new tarea();
            tablatarea.fecha = dtmFecha.Value.Date;
            //tablatarea.hora = new  TimeSpan(dtmHora.Value.Hour, dtmHora.Value.Minute, 0);
            //tablatarea.hora = new DateTime(dtmHora.Value.Hour, dtmHora.Value.Minute, 0);
            tablatarea.hora = dtmFecha.Value.Date.Add(dtmHora.Value.TimeOfDay);

            tablatarea.estado = 1;
            tablatarea.proceso_idproceso = Convert.ToInt32(cmbProcesos.SelectedValue);
            //tablatarea.proceso.idproceso = Convert.ToInt32(cmbProcesos.SelectedValue);

            if (tablatarea.insertar())
            {
                MessageBox.Show("Tarea Ingresada");
                hilo.reiniciarHilo();
                this.actualizarDgv();
            }
            else {
                MessageBox.Show("No puede existir dos tareas en la misma hora");
            }
        }

        private void actualizarDgv() {
            dgvTareas.DataSource = null;
            tarea tarea = new tarea();
            dgvTareas.DataSource = tarea.getAllTareas();
            dgvTareas.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.indexTarea > -1)
            {
                int idtarea = Convert.ToInt32(dgvTareas.Rows[this.indexTarea].Cells[0].Value.ToString());


                tarea tar = tarea.buscar(idtarea);
                if (tar.eliminar())
                {
                    MessageBox.Show("tarea eliminada");
                }
                else
                {
                    MessageBox.Show("tarea ya ejecutadas o en proceso de ejecución no pueden ser eliminadas");
                }
            }
            else {
                MessageBox.Show("Seleccione un registro a eliminar");
            }
            this.actualizarDgv();
        }

        private void dgvTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.indexTarea = e.RowIndex;

            var senderGrid = (DataGridView)sender;
            try
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    int idtarea = Convert.ToInt32(dgvTareas.Rows[this.indexTarea].Cells[0].Value.ToString());

                    FormDetalleTarea formulario = new FormDetalleTarea(tarea.buscar(idtarea));
                    formulario.ShowDialog();
                }
            }catch(Exception ex){
            
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan horaComponente = new  TimeSpan(dtmHora.Value.Hour, dtmHora.Value.Minute, 0);
            TimeSpan horaActual = new  TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
            if (horaComponente < horaActual) {
                this.establecerHora(DateTime.Now);
            }
        }

        private void establecerHora(DateTime fecha) {
            string date = fecha.Day.ToString() + "/" + fecha.Month.ToString() + "/" +
                fecha.Year.ToString() + " " + fecha.Hour.ToString() + ":" + fecha.Minute.ToString() + ":00";
            dtmHora.Value = Convert.ToDateTime(date);
        }

        private void dtmHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dtmHora_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void FormTareas_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.actualizarDgv();
        }

    }
}
