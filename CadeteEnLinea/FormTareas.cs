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
            dgvTareas.DataSource = tarea.getAllTareas();
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
    }
}
