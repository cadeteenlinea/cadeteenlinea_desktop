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
        }

        private void FormTareas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cadeteenlineaDataSet.tarea' Puede moverla o quitarla según sea necesario.
            this.tareaTableAdapter.Fill(this.cadeteenlineaDataSet.tarea);
            //dgvTareas.DataSource = tarea.getAllTareas();
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
            tablatarea.hora =  dtmHora.Value.Hour;
            tablatarea.estado = 0;
            tablatarea.proceso_idproceso = Convert.ToInt32(cmbProcesos.SelectedValue);
        }
    }
}
