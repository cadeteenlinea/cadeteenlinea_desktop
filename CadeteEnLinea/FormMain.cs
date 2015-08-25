using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CadeteEnLinea
{
    public partial class FormMain : Form
    {
        List<Error> result = new List<Error>();
        JavaScriptSerializer jss = new JavaScriptSerializer();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonActualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (result.Count() > 0) {
                result = new List<Error>();
                dgwErrores.DataSource = result;
            }
            this.enableBtn(false);


            this.setErrors(usuario.sendWeb(1));
            this.setErrors(usuario.sendWeb(2));
            this.setErrors(cadete.sendWeb(1));
            this.setErrors(cadete.sendWeb(2));
            this.setErrors(apoderado.sendWeb(1));
            this.setErrors(apoderado.sendWeb(2));
            this.setErrors(cadete_apoderado.sendWeb(1));
            this.setErrors(cadete_apoderado.sendWeb(2));
            this.setErrors(cadete_apoderado.sendWeb(3));
            this.setErrors(apoderado.sendWeb(3));
            this.setErrors(cadete.sendWeb(3));
            this.setErrors(usuario.sendWeb(3));

            if (result.Count() > 0) {
                dgwErrores.DataSource = result;
                dgwErrores.Update();
                dgwErrores.Refresh();
            }
            this.enableBtn(true);
            MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonActualizarTransacciones_Click(object sender, EventArgs e)
        {
            if (result.Count() > 0)
            {
                result = new List<Error>();
                dgwErrores.DataSource = result;
            }
            this.enableBtn(false);

            this.setErrors(transaccion.sendWeb(1));
            this.setErrors(transaccion.sendWeb(2));
            this.setErrors(transaccion.sendWeb(3));

            if (result.Count() > 0)
            {
                dgwErrores.DataSource = result;
                dgwErrores.Update();
                dgwErrores.Refresh();
            }
            this.enableBtn(true);
            MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result.Count() > 0)
            {
                result = new List<Error>();
                dgwErrores.DataSource = result;
            }
            this.enableBtn(false);

            this.setErrors(asignatura.sendWeb(1));
            this.setErrors(asignatura.sendWeb(2));
            this.setErrors(notas_parciales.sendWeb(1));
            this.setErrors(notas_parciales.sendWeb(2));
            this.setErrors(notas_parciales.sendWeb(3));
            this.setErrors(notas_finales.sendWeb(3));
            this.setErrors(asignatura.sendWeb(3));


            if (result.Count() > 0)
            {
                dgwErrores.DataSource = result;
                dgwErrores.Update();
                dgwErrores.Refresh();
            }
            this.enableBtn(true);
            MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonActualizarCalificaciones_Click(object sender, EventArgs e)
        {
            if (result.Count() > 0)
            {
                result = new List<Error>();
                dgwErrores.DataSource = result;
            }
            this.enableBtn(false);

            this.setErrors(calificaciones.sendWeb(1));
            this.setErrors(calificaciones.sendWeb(2));
            this.setErrors(calificaciones.sendWeb(3));


            if (result.Count() > 0)
            {
                dgwErrores.DataSource = result;
                dgwErrores.Update();
                dgwErrores.Refresh();
            }
            this.enableBtn(true);
            MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnActualizarNotasFinales_Click(object sender, EventArgs e)
        {
            if (result.Count() > 0)
            {
                result = new List<Error>();
                dgwErrores.DataSource = result;
            }
            this.enableBtn(false);

            this.setErrors(asignatura.sendWeb(1));
            this.setErrors(asignatura.sendWeb(2));
            this.setErrors(notas_finales.sendWeb(1));
            this.setErrors(notas_finales.sendWeb(2));
            this.setErrors(notas_finales.sendWeb(3));
            this.setErrors(notas_parciales.sendWeb(3));
            this.setErrors(asignatura.sendWeb(3));


            if (result.Count() > 0)
            {
                dgwErrores.DataSource = result;
                dgwErrores.Update();
                dgwErrores.Refresh();
            }
            this.enableBtn(true);
            MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnActualizarInglesTAE_Click(object sender, EventArgs e)
        {
            if (result.Count() > 0)
            {
                result = new List<Error>();
                dgwErrores.DataSource = result;
            }
            this.enableBtn(false);

            this.setErrors(ingles_tae.sendWeb(1));
            this.setErrors(ingles_tae.sendWeb(2));
            this.setErrors(ingles_tae.sendWeb(3));


            if (result.Count() > 0)
            {
                dgwErrores.DataSource = result;
                dgwErrores.Update();
                dgwErrores.Refresh();
            }
            this.enableBtn(true);
            MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void enableBtn(bool estado)
        {
            btnActualizarInglesTAE.Enabled = estado;
            btnActualizarNotasFinales.Enabled = estado;
            btnActualizarNotasParciales.Enabled = estado;
            btnActualizarTransacciones.Enabled = estado;
            btnActualizarUsuarios.Enabled = estado;
            btnActualizarCalificaciones.Enabled = estado;
        }

        private void setErrors(string errores)
        {
            var re = jss.DeserializeObject(errores);
            if (Convert.ToString(re)!=String.Empty)
            {
                if (re != " \\")
                {
                    result.AddRange(jss.Deserialize<List<Error>>(errores));
                }
            }
        }
    }
}
