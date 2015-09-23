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
    public partial class FormDetalleTarea : Form
    {
        private tarea tar = null;
        public FormDetalleTarea(tarea tar)
        {
            InitializeComponent();
            this.tar = tar;
        }

        private void FormDetalleTarea_Load(object sender, EventArgs e)
        {
            dgvErrores.DataSource = errores.getAllErroresTarea(tar.idtarea);
            dgvErrores.Refresh();
            lblFecha.Text = Convert.ToDateTime(tar.fecha + tar.hora).ToString();
            lblProceso.Text = tar.proceso.nombre;
        }

        private void actualizarDgv() { 
            
        }
    }
}
