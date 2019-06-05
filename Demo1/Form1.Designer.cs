namespace Demo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGVAlumno = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAlumnoToolStripMenuItem,
            this.buscarAlumnoToolStripMenuItem,
            this.editarAlumnoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // agregarAlumnoToolStripMenuItem
            // 
            this.agregarAlumnoToolStripMenuItem.Name = "agregarAlumnoToolStripMenuItem";
            this.agregarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarAlumnoToolStripMenuItem.Text = "Agregar alumno";
            this.agregarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.agregarAlumnoToolStripMenuItem_Click);
            // 
            // buscarAlumnoToolStripMenuItem
            // 
            this.buscarAlumnoToolStripMenuItem.Name = "buscarAlumnoToolStripMenuItem";
            this.buscarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarAlumnoToolStripMenuItem.Text = "Buscar alumno";
            this.buscarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.buscarAlumnoToolStripMenuItem_Click);
            // 
            // editarAlumnoToolStripMenuItem
            // 
            this.editarAlumnoToolStripMenuItem.Name = "editarAlumnoToolStripMenuItem";
            this.editarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarAlumnoToolStripMenuItem.Text = "Editar alumno";
            this.editarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.editarAlumnoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // DGVAlumno
            // 
            this.DGVAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAlumno.Location = new System.Drawing.Point(25, 69);
            this.DGVAlumno.Name = "DGVAlumno";
            this.DGVAlumno.Size = new System.Drawing.Size(824, 150);
            this.DGVAlumno.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 260);
            this.Controls.Add(this.DGVAlumno);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGVAlumno;
    }
}

