namespace CadeteEnLinea
{
    partial class FormDetalleTarea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvErrores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProceso = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvErrores
            // 
            this.dgvErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.tabla,
            this.registro,
            this.error});
            this.dgvErrores.Location = new System.Drawing.Point(12, 63);
            this.dgvErrores.Name = "dgvErrores";
            this.dgvErrores.Size = new System.Drawing.Size(659, 262);
            this.dgvErrores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de Ejecución :";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(129, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "0000/00/00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proceso :";
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(73, 31);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(46, 13);
            this.lblProceso.TabIndex = 4;
            this.lblProceso.Text = "-------------";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.FillWeight = 110F;
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.Width = 110;
            // 
            // tabla
            // 
            this.tabla.DataPropertyName = "tabla";
            this.tabla.FillWeight = 110F;
            this.tabla.HeaderText = "tabla";
            this.tabla.Name = "tabla";
            this.tabla.Width = 110;
            // 
            // registro
            // 
            this.registro.DataPropertyName = "registro";
            this.registro.HeaderText = "registro";
            this.registro.Name = "registro";
            // 
            // error
            // 
            this.error.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.error.DataPropertyName = "error";
            this.error.FillWeight = 280F;
            this.error.HeaderText = "error";
            this.error.Name = "error";
            this.error.Width = 280;
            // 
            // FormDetalleTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 337);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvErrores);
            this.Name = "FormDetalleTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de la Tarea";
            this.Load += new System.EventHandler(this.FormDetalleTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvErrores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
    }
}