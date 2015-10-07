namespace CadeteEnLinea
{
    partial class FormProcesoManual
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnActualizarUsuarios = new System.Windows.Forms.Button();
            this.btnActualizarTransacciones = new System.Windows.Forms.Button();
            this.btnActualizarNotasParciales = new System.Windows.Forms.Button();
            this.btnActualizarCalificaciones = new System.Windows.Forms.Button();
            this.btnActualizarNotasFinales = new System.Windows.Forms.Button();
            this.btnActualizarInglesTAE = new System.Windows.Forms.Button();
            this.dgwErrores = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarUsuarios
            // 
            this.btnActualizarUsuarios.Location = new System.Drawing.Point(12, 12);
            this.btnActualizarUsuarios.Name = "btnActualizarUsuarios";
            this.btnActualizarUsuarios.Size = new System.Drawing.Size(103, 69);
            this.btnActualizarUsuarios.TabIndex = 0;
            this.btnActualizarUsuarios.Text = "Actualizar Usuarios";
            this.btnActualizarUsuarios.UseVisualStyleBackColor = true;
            this.btnActualizarUsuarios.Click += new System.EventHandler(this.buttonActualizarUsuarios_Click);
            // 
            // btnActualizarTransacciones
            // 
            this.btnActualizarTransacciones.Location = new System.Drawing.Point(135, 12);
            this.btnActualizarTransacciones.Name = "btnActualizarTransacciones";
            this.btnActualizarTransacciones.Size = new System.Drawing.Size(103, 69);
            this.btnActualizarTransacciones.TabIndex = 1;
            this.btnActualizarTransacciones.Text = "Actualizar Transacciones";
            this.btnActualizarTransacciones.UseVisualStyleBackColor = true;
            this.btnActualizarTransacciones.Click += new System.EventHandler(this.buttonActualizarTransacciones_Click);
            // 
            // btnActualizarNotasParciales
            // 
            this.btnActualizarNotasParciales.Location = new System.Drawing.Point(263, 12);
            this.btnActualizarNotasParciales.Name = "btnActualizarNotasParciales";
            this.btnActualizarNotasParciales.Size = new System.Drawing.Size(98, 69);
            this.btnActualizarNotasParciales.TabIndex = 2;
            this.btnActualizarNotasParciales.Text = "Actualizar Notas Parciales";
            this.btnActualizarNotasParciales.UseVisualStyleBackColor = true;
            this.btnActualizarNotasParciales.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizarCalificaciones
            // 
            this.btnActualizarCalificaciones.Location = new System.Drawing.Point(621, 12);
            this.btnActualizarCalificaciones.Name = "btnActualizarCalificaciones";
            this.btnActualizarCalificaciones.Size = new System.Drawing.Size(103, 69);
            this.btnActualizarCalificaciones.TabIndex = 3;
            this.btnActualizarCalificaciones.Text = "Actualizar Calificaciones";
            this.btnActualizarCalificaciones.UseVisualStyleBackColor = true;
            this.btnActualizarCalificaciones.Click += new System.EventHandler(this.buttonActualizarCalificaciones_Click);
            // 
            // btnActualizarNotasFinales
            // 
            this.btnActualizarNotasFinales.Location = new System.Drawing.Point(381, 12);
            this.btnActualizarNotasFinales.Name = "btnActualizarNotasFinales";
            this.btnActualizarNotasFinales.Size = new System.Drawing.Size(103, 69);
            this.btnActualizarNotasFinales.TabIndex = 4;
            this.btnActualizarNotasFinales.Text = "Actualizar Notas Finales";
            this.btnActualizarNotasFinales.UseVisualStyleBackColor = true;
            this.btnActualizarNotasFinales.Click += new System.EventHandler(this.btnActualizarNotasFinales_Click);
            // 
            // btnActualizarInglesTAE
            // 
            this.btnActualizarInglesTAE.Location = new System.Drawing.Point(500, 12);
            this.btnActualizarInglesTAE.Name = "btnActualizarInglesTAE";
            this.btnActualizarInglesTAE.Size = new System.Drawing.Size(103, 69);
            this.btnActualizarInglesTAE.TabIndex = 5;
            this.btnActualizarInglesTAE.Text = "Actualizar Ingles TAE";
            this.btnActualizarInglesTAE.UseVisualStyleBackColor = true;
            this.btnActualizarInglesTAE.Click += new System.EventHandler(this.btnActualizarInglesTAE_Click);
            // 
            // dgwErrores
            // 
            this.dgwErrores.AllowUserToAddRows = false;
            this.dgwErrores.AllowUserToDeleteRows = false;
            this.dgwErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.tabla,
            this.idRegistro,
            this.error});
            this.dgwErrores.Location = new System.Drawing.Point(12, 99);
            this.dgwErrores.Name = "dgwErrores";
            this.dgwErrores.ReadOnly = true;
            this.dgwErrores.Size = new System.Drawing.Size(712, 285);
            this.dgwErrores.TabIndex = 6;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codigo.DataPropertyName = "codigo";
            this.codigo.FillWeight = 70F;
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 70;
            // 
            // tabla
            // 
            this.tabla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tabla.DataPropertyName = "tabla";
            this.tabla.FillWeight = 90F;
            this.tabla.HeaderText = "tabla";
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Width = 90;
            // 
            // idRegistro
            // 
            this.idRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idRegistro.DataPropertyName = "idRegistro";
            this.idRegistro.FillWeight = 80F;
            this.idRegistro.HeaderText = "Id";
            this.idRegistro.Name = "idRegistro";
            this.idRegistro.ReadOnly = true;
            this.idRegistro.Width = 80;
            // 
            // error
            // 
            this.error.DataPropertyName = "error";
            this.error.HeaderText = "error";
            this.error.Name = "error";
            this.error.ReadOnly = true;
            this.error.Width = 429;
            // 
            // FormProcesoManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 396);
            this.Controls.Add(this.dgwErrores);
            this.Controls.Add(this.btnActualizarInglesTAE);
            this.Controls.Add(this.btnActualizarNotasFinales);
            this.Controls.Add(this.btnActualizarCalificaciones);
            this.Controls.Add(this.btnActualizarNotasParciales);
            this.Controls.Add(this.btnActualizarTransacciones);
            this.Controls.Add(this.btnActualizarUsuarios);
            this.MaximizeBox = false;
            this.Name = "FormProcesoManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadete en Línea";
            ((System.ComponentModel.ISupportInitialize)(this.dgwErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarUsuarios;
        private System.Windows.Forms.Button btnActualizarTransacciones;
        private System.Windows.Forms.Button btnActualizarNotasParciales;
        private System.Windows.Forms.Button btnActualizarCalificaciones;
        private System.Windows.Forms.Button btnActualizarNotasFinales;
        private System.Windows.Forms.Button btnActualizarInglesTAE;
        private System.Windows.Forms.DataGridView dgwErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
    }
}

