namespace CadeteEnLinea
{
    partial class FormTareas
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
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.idtarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtmFecha = new System.Windows.Forms.DateTimePicker();
            this.dtmHora = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProcesos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtarea,
            this.fecha,
            this.hora,
            this.estado});
            this.dgvTareas.Location = new System.Drawing.Point(12, 169);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.Size = new System.Drawing.Size(677, 251);
            this.dgvTareas.TabIndex = 0;
            // 
            // idtarea
            // 
            this.idtarea.DataPropertyName = "idtarea";
            this.idtarea.HeaderText = "idtarea";
            this.idtarea.Name = "idtarea";
            this.idtarea.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "hora";
            this.hora.Name = "hora";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            // 
            // dtmFecha
            // 
            this.dtmFecha.CustomFormat = "dd-MM-yyyy";
            this.dtmFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFecha.Location = new System.Drawing.Point(69, 30);
            this.dtmFecha.Name = "dtmFecha";
            this.dtmFecha.Size = new System.Drawing.Size(117, 20);
            this.dtmFecha.TabIndex = 1;
            this.dtmFecha.Value = new System.DateTime(2015, 9, 1, 11, 24, 19, 0);
            this.dtmFecha.ValueChanged += new System.EventHandler(this.dtmFecha_ValueChanged);
            // 
            // dtmHora
            // 
            this.dtmHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmHora.Location = new System.Drawing.Point(192, 30);
            this.dtmHora.Name = "dtmHora";
            this.dtmHora.Size = new System.Drawing.Size(69, 20);
            this.dtmHora.TabIndex = 2;
            this.dtmHora.Value = new System.DateTime(2015, 9, 1, 11, 24, 19, 0);
            this.dtmHora.ValueChanged += new System.EventHandler(this.dtmHora_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProcesos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtmFecha);
            this.groupBox1.Controls.Add(this.dtmHora);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Tarea";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbProcesos
            // 
            this.cmbProcesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcesos.FormattingEnabled = true;
            this.cmbProcesos.Location = new System.Drawing.Point(356, 28);
            this.cmbProcesos.Name = "cmbProcesos";
            this.cmbProcesos.Size = new System.Drawing.Size(179, 21);
            this.cmbProcesos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proceso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTareas);
            this.Name = "FormTareas";
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.FormTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.DateTimePicker dtmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DateTimePicker dtmHora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProcesos;
        private System.Windows.Forms.Label label2;
    }
}