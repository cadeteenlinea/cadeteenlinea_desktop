namespace CadeteEnLinea
{
    partial class Form1
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
            this.buttonActualizarUsuarios = new System.Windows.Forms.Button();
            this.buttonActualizarTransacciones = new System.Windows.Forms.Button();
            this.buttonActualizarNotas = new System.Windows.Forms.Button();
            this.buttonActualizarCalificaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonActualizarUsuarios
            // 
            this.buttonActualizarUsuarios.Location = new System.Drawing.Point(92, 42);
            this.buttonActualizarUsuarios.Name = "buttonActualizarUsuarios";
            this.buttonActualizarUsuarios.Size = new System.Drawing.Size(103, 69);
            this.buttonActualizarUsuarios.TabIndex = 0;
            this.buttonActualizarUsuarios.Text = "Actualizar Usuarios";
            this.buttonActualizarUsuarios.UseVisualStyleBackColor = true;
            this.buttonActualizarUsuarios.Click += new System.EventHandler(this.buttonActualizarUsuarios_Click);
            // 
            // buttonActualizarTransacciones
            // 
            this.buttonActualizarTransacciones.Location = new System.Drawing.Point(225, 42);
            this.buttonActualizarTransacciones.Name = "buttonActualizarTransacciones";
            this.buttonActualizarTransacciones.Size = new System.Drawing.Size(103, 69);
            this.buttonActualizarTransacciones.TabIndex = 1;
            this.buttonActualizarTransacciones.Text = "Actualizar Transacciones";
            this.buttonActualizarTransacciones.UseVisualStyleBackColor = true;
            this.buttonActualizarTransacciones.Click += new System.EventHandler(this.buttonActualizarTransacciones_Click);
            // 
            // buttonActualizarNotas
            // 
            this.buttonActualizarNotas.Location = new System.Drawing.Point(358, 42);
            this.buttonActualizarNotas.Name = "buttonActualizarNotas";
            this.buttonActualizarNotas.Size = new System.Drawing.Size(98, 69);
            this.buttonActualizarNotas.TabIndex = 2;
            this.buttonActualizarNotas.Text = "Actualizar Notas Parciales - Finales - TAE";
            this.buttonActualizarNotas.UseVisualStyleBackColor = true;
            this.buttonActualizarNotas.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonActualizarCalificaciones
            // 
            this.buttonActualizarCalificaciones.Location = new System.Drawing.Point(225, 141);
            this.buttonActualizarCalificaciones.Name = "buttonActualizarCalificaciones";
            this.buttonActualizarCalificaciones.Size = new System.Drawing.Size(103, 69);
            this.buttonActualizarCalificaciones.TabIndex = 3;
            this.buttonActualizarCalificaciones.Text = "Actualizar Calificaciones";
            this.buttonActualizarCalificaciones.UseVisualStyleBackColor = true;
            this.buttonActualizarCalificaciones.Click += new System.EventHandler(this.buttonActualizarCalificaciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 269);
            this.Controls.Add(this.buttonActualizarCalificaciones);
            this.Controls.Add(this.buttonActualizarNotas);
            this.Controls.Add(this.buttonActualizarTransacciones);
            this.Controls.Add(this.buttonActualizarUsuarios);
            this.Name = "Form1";
            this.Text = "Cadete en Línea";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonActualizarUsuarios;
        private System.Windows.Forms.Button buttonActualizarTransacciones;
        private System.Windows.Forms.Button buttonActualizarNotas;
        private System.Windows.Forms.Button buttonActualizarCalificaciones;
    }
}

