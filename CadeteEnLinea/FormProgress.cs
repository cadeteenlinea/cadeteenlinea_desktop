using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadeteEnLinea
{
    public partial class FormProgress : Form
    {
        public Label lblDetalle;
        public FormProgress()
        {
            InitializeComponent();
            lblDetalle = this.lblPasos;
        }

        private void FormProgress_Load(object sender, EventArgs e)
        {

            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void actualizarUsuario(Label ldlDetalle)
        {
            ldlDetalle.Text = "asd";

            string resultUsuarioInsert = usuario.sendWeb(1);
            string resultUsuarioUpdate = usuario.sendWeb(1);

            ldlDetalle.Text = "weasd";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
