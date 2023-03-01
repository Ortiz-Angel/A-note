namespace Editor_de_texto
{
    partial class Anotes
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Edicion = new System.Windows.Forms.ToolStripMenuItem();
            this.formato = new System.Windows.Forms.ToolStripMenuItem();
            this.color = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.Atras = new System.Windows.Forms.ToolStripMenuItem();
            this.Adelante = new System.Windows.Forms.ToolStripMenuItem();
            this.Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionartodo = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(902, 430);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Edicion,
            this.formato,
            this.color,
            this.ComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Abrir,
            this.Guardar,
            this.Cerrar});
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(88, 33);
            this.Archivo.Text = "Archivo";
            this.Archivo.Click += new System.EventHandler(this.Archivo_Click);
            // 
            // Edicion
            // 
            this.Edicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Atras,
            this.Adelante,
            this.toolStripSeparator1,
            this.Copiar,
            this.cortar,
            this.pegar,
            this.seleccionartodo,
            this.eliminarTodo});
            this.Edicion.Name = "Edicion";
            this.Edicion.Size = new System.Drawing.Size(85, 33);
            this.Edicion.Text = "Edicion";
            this.Edicion.Click += new System.EventHandler(this.eDToolStripMenuItem_Click);
            // 
            // formato
            // 
            this.formato.Name = "formato";
            this.formato.Size = new System.Drawing.Size(96, 33);
            this.formato.Text = "Formato";
            this.formato.Click += new System.EventHandler(this.formato_Click);
            // 
            // color
            // 
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(71, 33);
            this.color.Text = "Color";
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(303, 6);
            // 
            // Abrir
            // 
            this.Abrir.Image = global::Editor_de_texto.Properties.Resources.icons8_abrir_en_popup_32;
            this.Abrir.Name = "Abrir";
            this.Abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Abrir.Size = new System.Drawing.Size(270, 34);
            this.Abrir.Text = "Abrir";
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Guardar
            // 
            this.Guardar.Image = global::Editor_de_texto.Properties.Resources.icons8_guardar_30;
            this.Guardar.Name = "Guardar";
            this.Guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Guardar.Size = new System.Drawing.Size(270, 34);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Image = global::Editor_de_texto.Properties.Resources.icons8_cerrar_ventana_32;
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Cerrar.Size = new System.Drawing.Size(270, 34);
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Atras
            // 
            this.Atras.Image = global::Editor_de_texto.Properties.Resources.icons8_atrás_32;
            this.Atras.Name = "Atras";
            this.Atras.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Atras.Size = new System.Drawing.Size(306, 34);
            this.Atras.Text = "Atras";
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Adelante
            // 
            this.Adelante.Image = global::Editor_de_texto.Properties.Resources.icons8_flecha_adelante_30;
            this.Adelante.Name = "Adelante";
            this.Adelante.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.Adelante.Size = new System.Drawing.Size(306, 34);
            this.Adelante.Text = "Adelante";
            this.Adelante.Click += new System.EventHandler(this.Adelante_Click);
            // 
            // Copiar
            // 
            this.Copiar.Image = global::Editor_de_texto.Properties.Resources.icons8_copiar_24;
            this.Copiar.Name = "Copiar";
            this.Copiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copiar.Size = new System.Drawing.Size(306, 34);
            this.Copiar.Text = "Copiar";
            this.Copiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // cortar
            // 
            this.cortar.Image = global::Editor_de_texto.Properties.Resources.icons8_cortar_papel_30;
            this.cortar.Name = "cortar";
            this.cortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortar.Size = new System.Drawing.Size(306, 34);
            this.cortar.Text = "Cortar";
            this.cortar.Click += new System.EventHandler(this.cortar_Click);
            // 
            // pegar
            // 
            this.pegar.Image = global::Editor_de_texto.Properties.Resources.icons8_pegar_30;
            this.pegar.Name = "pegar";
            this.pegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegar.Size = new System.Drawing.Size(306, 34);
            this.pegar.Text = "Pegar";
            this.pegar.Click += new System.EventHandler(this.pegar_Click);
            // 
            // seleccionartodo
            // 
            this.seleccionartodo.Image = global::Editor_de_texto.Properties.Resources.icons8_marque_todas_las_30;
            this.seleccionartodo.Name = "seleccionartodo";
            this.seleccionartodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.seleccionartodo.Size = new System.Drawing.Size(306, 34);
            this.seleccionartodo.Text = "Seleccionar todo";
            this.seleccionartodo.Click += new System.EventHandler(this.seleccionartodo_Click);
            // 
            // eliminarTodo
            // 
            this.eliminarTodo.Image = global::Editor_de_texto.Properties.Resources.icons8_eliminar_24;
            this.eliminarTodo.Name = "eliminarTodo";
            this.eliminarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.eliminarTodo.Size = new System.Drawing.Size(306, 34);
            this.eliminarTodo.Text = "Eliminar todo";
            this.eliminarTodo.Click += new System.EventHandler(this.eliminarTodo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ComboBox1
            // 
            this.ComboBox1.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "18",
            "20",
            "24",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40",
            "42"});
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 33);
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.Seleccionar_tamaño);
            // 
            // Anotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 467);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anotes";
            this.Text = "A-notes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem Abrir;
        private System.Windows.Forms.ToolStripMenuItem Guardar;
        private System.Windows.Forms.ToolStripMenuItem Cerrar;
        private System.Windows.Forms.ToolStripMenuItem Edicion;
        private System.Windows.Forms.ToolStripMenuItem formato;
        private System.Windows.Forms.ToolStripMenuItem color;
        private System.Windows.Forms.ToolStripMenuItem Atras;
        private System.Windows.Forms.ToolStripMenuItem Adelante;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Copiar;
        private System.Windows.Forms.ToolStripMenuItem cortar;
        private System.Windows.Forms.ToolStripMenuItem pegar;
        private System.Windows.Forms.ToolStripMenuItem seleccionartodo;
        private System.Windows.Forms.ToolStripMenuItem eliminarTodo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripComboBox ComboBox1;
    }
}

