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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonActualizarUsuarios_Click(object sender, EventArgs e)
        {
            string resultUsuarioInsert = usuario.sendWeb(1);
            string resultUsuarioUpdate = usuario.sendWeb(1);

            string resultCadeteApoderadoDelete = cadete_apoderado.sendWeb(3);

            string resultCadetesInsert = cadete.sendWeb(1);
            string resultCadetesUpdate = cadete.sendWeb(2);
            string resultCadetesDelete = cadete.sendWeb(3);

            string resultApoderadosInsert = apoderado.sendWeb(1);
            string resultApoderadosUpdate = apoderado.sendWeb(2);
            string resultApoderadosDelete = apoderado.sendWeb(3);

            string resultCadeteApoderadoInsert = cadete_apoderado.sendWeb(1);
            string resultCadeteApoderadoUpdate = cadete_apoderado.sendWeb(2);

            string resultUsuarioDelete = usuario.sendWeb(3);
        }

        private void buttonActualizarTransacciones_Click(object sender, EventArgs e)
        {
            string resultTransaccionInsert = transaccion.sendWeb(1);
            string resultTransaccionUpdate = transaccion.sendWeb(2);
            string resultTransaccionDelete = transaccion.sendWeb(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultAsignaturasInsert = asignatura.sendWeb(1);
            string resultAsignaturasUpdate = asignatura.sendWeb(2);

            string resultNotasParcialesInsert = notas_parciales.sendWeb(1);
            string resultNotasParcialesUpdate = notas_parciales.sendWeb(2);
            string resultNotasParcialesDelete = notas_parciales.sendWeb(3);

            string resultAsignaturasDelete = asignatura.sendWeb(3);
        }

        private void buttonActualizarCalificaciones_Click(object sender, EventArgs e)
        {
            string resultCalificacionesInsert = calificaciones.sendWeb(1);
            string resultCalificacionesUpdate = calificaciones.sendWeb(2);
            string resultCalificacionesDelete = calificaciones.sendWeb(3);
        }

        private void btnActualizarNotasFinales_Click(object sender, EventArgs e)
        {
            string resultAsignaturasInsert = asignatura.sendWeb(1);
            string resultAsignaturasUpdate = asignatura.sendWeb(2);

            string resultNotasFinalesInsert = notas_finales.sendWeb(1);
            string resultNotasFinalesupdate = notas_finales.sendWeb(2);
            string resultNotasFinalesDelete = notas_finales.sendWeb(3);

            string resultAsignaturasDelete = asignatura.sendWeb(3);
        }

        private void btnActualizarInglesTAE_Click(object sender, EventArgs e)
        {
            string resultInglesInsert = ingles_tae.sendWeb(1);
            string resultInglesUpdate = ingles_tae.sendWeb(2);
            string resultInglesDelete = ingles_tae.sendWeb(3);
        }
    }
}