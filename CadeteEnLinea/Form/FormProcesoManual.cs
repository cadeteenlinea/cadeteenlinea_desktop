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
    public partial class FormProcesoManual : Form
    {
        List<errores> result = new List<errores>();
        JavaScriptSerializer jss = new JavaScriptSerializer();
        private cadeteenlineaEntities conexion = new cadeteenlineaEntities();

        public FormProcesoManual()
        {
            InitializeComponent();
        }

        private void buttonActualizarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                this.enableBtn(false);

                var proceso = conexion.proceso.Where(p => p.idproceso == 1).First();
                etl etlEjecutar = new etl(proceso);
                etlEjecutar.ejecutar();

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

                if (result.Count() > 0)
                {
                    result = new List<errores>();
                    dgwErrores.DataSource = result;
                }


                if (result.Count() > 0)
                {
                    dgwErrores.DataSource = result;
                    dgwErrores.Update();
                    dgwErrores.Refresh();
                }
                this.enableBtn(true);
                MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.enableBtn(true);
            }
        }

        private void buttonActualizarTransacciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (result.Count() > 0)
                {
                    result = new List<errores>();
                    dgwErrores.DataSource = result;
                }
                this.enableBtn(false);

                var proceso = conexion.proceso.Where(p => p.idproceso == 5).First();
                etl etlEjecutar = new etl(proceso);
                etlEjecutar.ejecutar();

                this.setErrors(usuario.sendWeb(1));
                this.setErrors(usuario.sendWeb(2));
                this.setErrors(cadete.sendWeb(1));
                this.setErrors(cadete.sendWeb(2));
                this.setErrors(apoderado.sendWeb(1));
                this.setErrors(apoderado.sendWeb(2));
                this.setErrors(cadete_apoderado.sendWeb(1));
                this.setErrors(cadete_apoderado.sendWeb(2));

                this.setErrors(transaccion.sendWeb(1));
                this.setErrors(transaccion.sendWeb(2));
                this.setErrors(transaccion.sendWeb(3));

                this.setErrors(cadete_apoderado.sendWeb(3));
                this.setErrors(apoderado.sendWeb(3));
                this.setErrors(cadete.sendWeb(3));
                this.setErrors(usuario.sendWeb(3));


                if (result.Count() > 0)
                {
                    dgwErrores.DataSource = result;
                    dgwErrores.Update();
                    dgwErrores.Refresh();
                }
                this.enableBtn(true);
                MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.enableBtn(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (result.Count() > 0)
                {
                    result = new List<errores>();
                    dgwErrores.DataSource = result;
                }
                this.enableBtn(false);

                var proceso = conexion.proceso.Where(p => p.idproceso == 2).First();
                etl etlEjecutar = new etl(proceso);
                etlEjecutar.ejecutar();

                this.setErrors(usuario.sendWeb(1));
                this.setErrors(usuario.sendWeb(2));
                this.setErrors(cadete.sendWeb(1));
                this.setErrors(cadete.sendWeb(2));
                this.setErrors(apoderado.sendWeb(1));
                this.setErrors(apoderado.sendWeb(2));
                this.setErrors(cadete_apoderado.sendWeb(1));
                this.setErrors(cadete_apoderado.sendWeb(2));

                this.setErrors(asignatura.sendWeb(1));
                this.setErrors(asignatura.sendWeb(2));
                this.setErrors(notas_parciales.sendWeb(1));
                this.setErrors(notas_parciales.sendWeb(2));
                this.setErrors(notas_parciales.sendWeb(3));
                this.setErrors(notas_finales.sendWeb(3));
                this.setErrors(asignatura.sendWeb(3));

                this.setErrors(cadete_apoderado.sendWeb(3));
                this.setErrors(apoderado.sendWeb(3));
                this.setErrors(cadete.sendWeb(3));
                this.setErrors(usuario.sendWeb(3));

                if (result.Count() > 0)
                {
                    dgwErrores.DataSource = result;
                    dgwErrores.Update();
                    dgwErrores.Refresh();
                }
                this.enableBtn(true);
                MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.enableBtn(true);
            }
        }

        private void buttonActualizarCalificaciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (result.Count() > 0)
                {
                    result = new List<errores>();
                    dgwErrores.DataSource = result;
                }
                this.enableBtn(false);

                var proceso = conexion.proceso.Where(p => p.idproceso == 3).First();
                etl etlEjecutar = new etl(proceso);
                etlEjecutar.ejecutar();

                this.setErrors(usuario.sendWeb(1));
                this.setErrors(usuario.sendWeb(2));
                this.setErrors(cadete.sendWeb(1));
                this.setErrors(cadete.sendWeb(2));
                this.setErrors(apoderado.sendWeb(1));
                this.setErrors(apoderado.sendWeb(2));
                this.setErrors(cadete_apoderado.sendWeb(1));
                this.setErrors(cadete_apoderado.sendWeb(2));

                this.setErrors(calificaciones.sendWeb(1));
                this.setErrors(calificaciones.sendWeb(2));
                this.setErrors(calificaciones.sendWeb(3));

                this.setErrors(cadete_apoderado.sendWeb(3));
                this.setErrors(apoderado.sendWeb(3));
                this.setErrors(cadete.sendWeb(3));
                this.setErrors(usuario.sendWeb(3));


                if (result.Count() > 0)
                {
                    dgwErrores.DataSource = result;
                    dgwErrores.Update();
                    dgwErrores.Refresh();
                }
                this.enableBtn(true);
                MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.enableBtn(true);
            }
        }

        private void btnActualizarNotasFinales_Click(object sender, EventArgs e)
        {
            try
            {
                if (result.Count() > 0)
                {
                    result = new List<errores>();
                    dgwErrores.DataSource = result;
                }
                this.enableBtn(false);

                var proceso = conexion.proceso.Where(p => p.idproceso == 6).First();
                etl etlEjecutar = new etl(proceso);
                etlEjecutar.ejecutar();

                this.setErrors(usuario.sendWeb(1));
                this.setErrors(usuario.sendWeb(2));
                this.setErrors(cadete.sendWeb(1));
                this.setErrors(cadete.sendWeb(2));
                this.setErrors(apoderado.sendWeb(1));
                this.setErrors(apoderado.sendWeb(2));
                this.setErrors(cadete_apoderado.sendWeb(1));
                this.setErrors(cadete_apoderado.sendWeb(2));

                this.setErrors(asignatura.sendWeb(1));
                this.setErrors(asignatura.sendWeb(2));
                this.setErrors(notas_finales.sendWeb(1));
                this.setErrors(notas_finales.sendWeb(2));
                this.setErrors(notas_finales.sendWeb(3));
                this.setErrors(notas_parciales.sendWeb(3));
                this.setErrors(asignatura.sendWeb(3));

                this.setErrors(cadete_apoderado.sendWeb(3));
                this.setErrors(apoderado.sendWeb(3));
                this.setErrors(cadete.sendWeb(3));
                this.setErrors(usuario.sendWeb(3));

                if (result.Count() > 0)
                {
                    dgwErrores.DataSource = result;
                    dgwErrores.Update();
                    dgwErrores.Refresh();
                }
                this.enableBtn(true);
                MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.enableBtn(true);
            }
        }

        private void btnActualizarInglesTAE_Click(object sender, EventArgs e)
        {
            try
            {
                if (result.Count() > 0)
                {
                    result = new List<errores>();
                    dgwErrores.DataSource = result;
                }
                this.enableBtn(false);

                var proceso = conexion.proceso.Where(p => p.idproceso == 4).First();
                etl etlEjecutar = new etl(proceso);
                etlEjecutar.ejecutar();

                this.setErrors(usuario.sendWeb(1));
                this.setErrors(usuario.sendWeb(2));
                this.setErrors(cadete.sendWeb(1));
                this.setErrors(cadete.sendWeb(2));
                this.setErrors(apoderado.sendWeb(1));
                this.setErrors(apoderado.sendWeb(2));
                this.setErrors(cadete_apoderado.sendWeb(1));
                this.setErrors(cadete_apoderado.sendWeb(2));

                this.setErrors(ingles_tae.sendWeb(1));
                this.setErrors(ingles_tae.sendWeb(2));
                this.setErrors(ingles_tae.sendWeb(3));

                this.setErrors(cadete_apoderado.sendWeb(3));
                this.setErrors(apoderado.sendWeb(3));
                this.setErrors(cadete.sendWeb(3));
                this.setErrors(usuario.sendWeb(3));


                if (result.Count() > 0)
                {
                    dgwErrores.DataSource = result;
                    dgwErrores.Update();
                    dgwErrores.Refresh();
                }
                this.enableBtn(true);
                MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.enableBtn(true);
            }
        }


        private void enableBtn(bool estado)
        {
            btnActualizarInglesTAE.Enabled = estado;
            btnActualizarNotasFinales.Enabled = estado;
            btnActualizarNotasParciales.Enabled = estado;
            btnActualizarTransacciones.Enabled = estado;
            btnActualizarUsuarios.Enabled = estado;
            btnActualizarCalificaciones.Enabled = estado;
            btnActualizarNotasFisicas.Enabled = estado;
            btnActualizarSituacionMilitar.Enabled = estado;
        }

        private void setErrors(string errores)
        {
            var re = jss.DeserializeObject(errores);
            if (Convert.ToString(re)!=String.Empty)
            {
                if (re != " \\")
                {
                    result.AddRange(jss.Deserialize<List<errores>>(errores));
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (result.Count() > 0)
                {
                    result = new List<errores>();
                    dgwErrores.DataSource = result;
                }
                this.enableBtn(false);

                var proceso = conexion.proceso.Where(p => p.idproceso == 7).First();
                etl etlEjecutar = new etl(proceso);
                etlEjecutar.ejecutar();

                this.setErrors(usuario.sendWeb(1));
                this.setErrors(usuario.sendWeb(2));
                this.setErrors(cadete.sendWeb(1));
                this.setErrors(cadete.sendWeb(2));
                this.setErrors(apoderado.sendWeb(1));
                this.setErrors(apoderado.sendWeb(2));
                this.setErrors(cadete_apoderado.sendWeb(1));
                this.setErrors(cadete_apoderado.sendWeb(2));

                this.setErrors(notas_fisico.sendWeb(1));
                this.setErrors(notas_fisico.sendWeb(2));
                this.setErrors(notas_fisico.sendWeb(3));
                this.setErrors(nivelacion.sendWeb(1));
                this.setErrors(nivelacion.sendWeb(2));
                this.setErrors(nivelacion.sendWeb(3));

                this.setErrors(cadete_apoderado.sendWeb(3));
                this.setErrors(apoderado.sendWeb(3));
                this.setErrors(cadete.sendWeb(3));
                this.setErrors(usuario.sendWeb(3));



                if (result.Count() > 0)
                {
                    dgwErrores.DataSource = result;
                    dgwErrores.Update();
                    dgwErrores.Refresh();
                }
                this.enableBtn(true);
                MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.enableBtn(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (result.Count() > 0)
                {
                    result = new List<errores>();
                    dgwErrores.DataSource = result;
                }
                this.enableBtn(false);

                var proceso = conexion.proceso.Where(p => p.idproceso == 8).First();
                etl etlEjecutar = new etl(proceso);
                etlEjecutar.ejecutar();

                this.setErrors(usuario.sendWeb(1));
                this.setErrors(usuario.sendWeb(2));
                this.setErrors(cadete.sendWeb(1));
                this.setErrors(cadete.sendWeb(2));
                this.setErrors(apoderado.sendWeb(1));
                this.setErrors(apoderado.sendWeb(2));
                this.setErrors(cadete_apoderado.sendWeb(1));
                this.setErrors(cadete_apoderado.sendWeb(2));
                this.setErrors(francos.sendWeb(1));
                this.setErrors(cadete_apoderado.sendWeb(3));
                this.setErrors(apoderado.sendWeb(3));
                this.setErrors(cadete.sendWeb(3));
                this.setErrors(usuario.sendWeb(3));

                if (result.Count() > 0)
                {
                    dgwErrores.DataSource = result;
                    dgwErrores.Update();
                    dgwErrores.Refresh();
                }
                this.enableBtn(true);
                MessageBox.Show("Proceso finalizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.enableBtn(true);
            }
        }
    }
}
