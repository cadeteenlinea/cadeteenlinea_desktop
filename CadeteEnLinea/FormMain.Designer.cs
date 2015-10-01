namespace CadeteEnLinea
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecuciónManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.tareasToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.ventanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.salirToolStripMenuItem.Text = "Cerrar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechasToolStripMenuItem});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // fechasToolStripMenuItem
            // 
            this.fechasToolStripMenuItem.Name = "fechasToolStripMenuItem";
            this.fechasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fechasToolStripMenuItem.Text = "Mantenedor";
            this.fechasToolStripMenuItem.Click += new System.EventHandler(this.fechasToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecuciónManualToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            this.procesosToolStripMenuItem.Visible = false;
            // 
            // ejecuciónManualToolStripMenuItem
            // 
            this.ejecuciónManualToolStripMenuItem.Name = "ejecuciónManualToolStripMenuItem";
            this.ejecuciónManualToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ejecuciónManualToolStripMenuItem.Text = "Ejecución Manual";
            this.ejecuciónManualToolStripMenuItem.Click += new System.EventHandler(this.ejecuciónManualToolStripMenuItem_Click);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizarToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Cadete en Línea";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.mantenedorTareasToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(188, 70);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.abrirToolStripMenuItem.Text = "Abrir Cadete en Línea";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // mantenedorTareasToolStripMenuItem
            // 
            this.mantenedorTareasToolStripMenuItem.Name = "mantenedorTareasToolStripMenuItem";
            this.mantenedorTareasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.mantenedorTareasToolStripMenuItem.Text = "Mantenedor Tareas";
            this.mantenedorTareasToolStripMenuItem.Click += new System.EventHandler(this.mantenedorTareasToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 357);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadete en Línea";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecuciónManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechasToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorTareasToolStripMenuItem;
    }
}