namespace TP2WinFormsG21A
{
    partial class FRMmenuPrincipal
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
            this.LBLbusqueda = new System.Windows.Forms.Label();
            this.TXTbuscar = new System.Windows.Forms.TextBox();
            this.CMBbusqueda = new System.Windows.Forms.ComboBox();
            this.BTNbuscar = new System.Windows.Forms.Button();
            this.GBXbuscar = new System.Windows.Forms.GroupBox();
            this.GBXagregar = new System.Windows.Forms.GroupBox();
            this.PBXeliminar = new System.Windows.Forms.GroupBox();
            this.BTNeliminarPorCodigo = new System.Windows.Forms.Button();
            this.LBLeliminarPorCodigo = new System.Windows.Forms.Label();
            this.TXBeliminarPorCodigo = new System.Windows.Forms.TextBox();
            this.LBLeliminarPorNombreYMarca = new System.Windows.Forms.Label();
            this.LBLeliminarNombre = new System.Windows.Forms.Label();
            this.LBLeliminarMarca = new System.Windows.Forms.Label();
            this.TXBelminarNombre = new System.Windows.Forms.TextBox();
            this.TXBelimarMarca = new System.Windows.Forms.TextBox();
            this.BTNeliminarPorCodigoYMarca = new System.Windows.Forms.Button();
            this.LBLcodigo = new System.Windows.Forms.Label();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.LBLdescripcion = new System.Windows.Forms.Label();
            this.LBLmarca = new System.Windows.Forms.Label();
            this.LBLcategoria = new System.Windows.Forms.Label();
            this.LBLprecio = new System.Windows.Forms.Label();
            this.LBLimagen = new System.Windows.Forms.Label();
            this.TXBcodigo = new System.Windows.Forms.TextBox();
            this.TXBnomnre = new System.Windows.Forms.TextBox();
            this.CMBcategoria = new System.Windows.Forms.ComboBox();
            this.CMBmarca = new System.Windows.Forms.ComboBox();
            this.TXBprecio = new System.Windows.Forms.TextBox();
            this.PTBimagen = new System.Windows.Forms.PictureBox();
            this.TXBdescripcion = new System.Windows.Forms.TextBox();
            this.LBLcargarImagen = new System.Windows.Forms.Label();
            this.TXBcargarImagen = new System.Windows.Forms.TextBox();
            this.modificarArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSlistarArtículos = new System.Windows.Forms.ToolStripMenuItem();
            this.porMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BTNdetalle = new System.Windows.Forms.Button();
            this.GBXbuscar.SuspendLayout();
            this.GBXagregar.SuspendLayout();
            this.PBXeliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTBimagen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLbusqueda
            // 
            this.LBLbusqueda.AutoSize = true;
            this.LBLbusqueda.Location = new System.Drawing.Point(6, 28);
            this.LBLbusqueda.Name = "LBLbusqueda";
            this.LBLbusqueda.Size = new System.Drawing.Size(130, 13);
            this.LBLbusqueda.TabIndex = 1;
            this.LBLbusqueda.Text = "Búsqueda de artículo por:";
            this.LBLbusqueda.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXTbuscar
            // 
            this.TXTbuscar.Location = new System.Drawing.Point(8, 55);
            this.TXTbuscar.Name = "TXTbuscar";
            this.TXTbuscar.Size = new System.Drawing.Size(255, 20);
            this.TXTbuscar.TabIndex = 2;
            this.TXTbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CMBbusqueda
            // 
            this.CMBbusqueda.FormattingEnabled = true;
            this.CMBbusqueda.Location = new System.Drawing.Point(142, 25);
            this.CMBbusqueda.Name = "CMBbusqueda";
            this.CMBbusqueda.Size = new System.Drawing.Size(121, 21);
            this.CMBbusqueda.TabIndex = 3;
            this.CMBbusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BTNbuscar
            // 
            this.BTNbuscar.Location = new System.Drawing.Point(40, 81);
            this.BTNbuscar.Name = "BTNbuscar";
            this.BTNbuscar.Size = new System.Drawing.Size(75, 23);
            this.BTNbuscar.TabIndex = 4;
            this.BTNbuscar.Text = "Buscar";
            this.BTNbuscar.UseVisualStyleBackColor = true;
            // 
            // GBXbuscar
            // 
            this.GBXbuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GBXbuscar.Controls.Add(this.BTNdetalle);
            this.GBXbuscar.Controls.Add(this.LBLbusqueda);
            this.GBXbuscar.Controls.Add(this.BTNbuscar);
            this.GBXbuscar.Controls.Add(this.TXTbuscar);
            this.GBXbuscar.Controls.Add(this.CMBbusqueda);
            this.GBXbuscar.Location = new System.Drawing.Point(12, 32);
            this.GBXbuscar.Name = "GBXbuscar";
            this.GBXbuscar.Size = new System.Drawing.Size(281, 121);
            this.GBXbuscar.TabIndex = 5;
            this.GBXbuscar.TabStop = false;
            this.GBXbuscar.Text = "Buscar artículos";
            this.GBXbuscar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GBXagregar
            // 
            this.GBXagregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GBXagregar.Controls.Add(this.TXBcargarImagen);
            this.GBXagregar.Controls.Add(this.LBLcargarImagen);
            this.GBXagregar.Controls.Add(this.TXBdescripcion);
            this.GBXagregar.Controls.Add(this.PTBimagen);
            this.GBXagregar.Controls.Add(this.TXBprecio);
            this.GBXagregar.Controls.Add(this.CMBmarca);
            this.GBXagregar.Controls.Add(this.CMBcategoria);
            this.GBXagregar.Controls.Add(this.TXBnomnre);
            this.GBXagregar.Controls.Add(this.TXBcodigo);
            this.GBXagregar.Controls.Add(this.LBLimagen);
            this.GBXagregar.Controls.Add(this.LBLprecio);
            this.GBXagregar.Controls.Add(this.LBLcategoria);
            this.GBXagregar.Controls.Add(this.LBLmarca);
            this.GBXagregar.Controls.Add(this.LBLdescripcion);
            this.GBXagregar.Controls.Add(this.LBLnombre);
            this.GBXagregar.Controls.Add(this.LBLcodigo);
            this.GBXagregar.Location = new System.Drawing.Point(308, 32);
            this.GBXagregar.Name = "GBXagregar";
            this.GBXagregar.Size = new System.Drawing.Size(281, 379);
            this.GBXagregar.TabIndex = 6;
            this.GBXagregar.TabStop = false;
            this.GBXagregar.Text = "Agregar artículo";
            // 
            // PBXeliminar
            // 
            this.PBXeliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PBXeliminar.Controls.Add(this.BTNeliminarPorCodigoYMarca);
            this.PBXeliminar.Controls.Add(this.TXBelimarMarca);
            this.PBXeliminar.Controls.Add(this.TXBelminarNombre);
            this.PBXeliminar.Controls.Add(this.LBLeliminarMarca);
            this.PBXeliminar.Controls.Add(this.LBLeliminarNombre);
            this.PBXeliminar.Controls.Add(this.LBLeliminarPorNombreYMarca);
            this.PBXeliminar.Controls.Add(this.TXBeliminarPorCodigo);
            this.PBXeliminar.Controls.Add(this.LBLeliminarPorCodigo);
            this.PBXeliminar.Controls.Add(this.BTNeliminarPorCodigo);
            this.PBXeliminar.Location = new System.Drawing.Point(12, 170);
            this.PBXeliminar.Name = "PBXeliminar";
            this.PBXeliminar.Size = new System.Drawing.Size(281, 241);
            this.PBXeliminar.TabIndex = 7;
            this.PBXeliminar.TabStop = false;
            this.PBXeliminar.Text = "Eliminar artículos";
            // 
            // BTNeliminarPorCodigo
            // 
            this.BTNeliminarPorCodigo.Location = new System.Drawing.Point(95, 48);
            this.BTNeliminarPorCodigo.Name = "BTNeliminarPorCodigo";
            this.BTNeliminarPorCodigo.Size = new System.Drawing.Size(75, 23);
            this.BTNeliminarPorCodigo.TabIndex = 0;
            this.BTNeliminarPorCodigo.Text = "Eliminar";
            this.BTNeliminarPorCodigo.UseVisualStyleBackColor = true;
            // 
            // LBLeliminarPorCodigo
            // 
            this.LBLeliminarPorCodigo.AutoSize = true;
            this.LBLeliminarPorCodigo.Location = new System.Drawing.Point(6, 25);
            this.LBLeliminarPorCodigo.Name = "LBLeliminarPorCodigo";
            this.LBLeliminarPorCodigo.Size = new System.Drawing.Size(99, 13);
            this.LBLeliminarPorCodigo.TabIndex = 1;
            this.LBLeliminarPorCodigo.Text = "Eliminar por código:";
            // 
            // TXBeliminarPorCodigo
            // 
            this.TXBeliminarPorCodigo.Location = new System.Drawing.Point(111, 22);
            this.TXBeliminarPorCodigo.Name = "TXBeliminarPorCodigo";
            this.TXBeliminarPorCodigo.Size = new System.Drawing.Size(152, 20);
            this.TXBeliminarPorCodigo.TabIndex = 5;
            this.TXBeliminarPorCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LBLeliminarPorNombreYMarca
            // 
            this.LBLeliminarPorNombreYMarca.AutoSize = true;
            this.LBLeliminarPorNombreYMarca.Location = new System.Drawing.Point(65, 113);
            this.LBLeliminarPorNombreYMarca.Name = "LBLeliminarPorNombreYMarca";
            this.LBLeliminarPorNombreYMarca.Size = new System.Drawing.Size(139, 13);
            this.LBLeliminarPorNombreYMarca.TabIndex = 6;
            this.LBLeliminarPorNombreYMarca.Text = "Eliminar por nombre y marca";
            // 
            // LBLeliminarNombre
            // 
            this.LBLeliminarNombre.AutoSize = true;
            this.LBLeliminarNombre.Location = new System.Drawing.Point(7, 140);
            this.LBLeliminarNombre.Name = "LBLeliminarNombre";
            this.LBLeliminarNombre.Size = new System.Drawing.Size(47, 13);
            this.LBLeliminarNombre.TabIndex = 7;
            this.LBLeliminarNombre.Text = "Nombre:";
            this.LBLeliminarNombre.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LBLeliminarMarca
            // 
            this.LBLeliminarMarca.AutoSize = true;
            this.LBLeliminarMarca.Location = new System.Drawing.Point(140, 140);
            this.LBLeliminarMarca.Name = "LBLeliminarMarca";
            this.LBLeliminarMarca.Size = new System.Drawing.Size(40, 13);
            this.LBLeliminarMarca.TabIndex = 8;
            this.LBLeliminarMarca.Text = "Marca:";
            this.LBLeliminarMarca.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // TXBelminarNombre
            // 
            this.TXBelminarNombre.Location = new System.Drawing.Point(60, 137);
            this.TXBelminarNombre.Name = "TXBelminarNombre";
            this.TXBelminarNombre.Size = new System.Drawing.Size(77, 20);
            this.TXBelminarNombre.TabIndex = 9;
            // 
            // TXBelimarMarca
            // 
            this.TXBelimarMarca.Location = new System.Drawing.Point(186, 137);
            this.TXBelimarMarca.Name = "TXBelimarMarca";
            this.TXBelimarMarca.Size = new System.Drawing.Size(77, 20);
            this.TXBelimarMarca.TabIndex = 10;
            // 
            // BTNeliminarPorCodigoYMarca
            // 
            this.BTNeliminarPorCodigoYMarca.Location = new System.Drawing.Point(95, 173);
            this.BTNeliminarPorCodigoYMarca.Name = "BTNeliminarPorCodigoYMarca";
            this.BTNeliminarPorCodigoYMarca.Size = new System.Drawing.Size(75, 23);
            this.BTNeliminarPorCodigoYMarca.TabIndex = 11;
            this.BTNeliminarPorCodigoYMarca.Text = "Eliminar";
            this.BTNeliminarPorCodigoYMarca.UseVisualStyleBackColor = true;
            // 
            // LBLcodigo
            // 
            this.LBLcodigo.AutoSize = true;
            this.LBLcodigo.Location = new System.Drawing.Point(20, 25);
            this.LBLcodigo.Name = "LBLcodigo";
            this.LBLcodigo.Size = new System.Drawing.Size(43, 13);
            this.LBLcodigo.TabIndex = 0;
            this.LBLcodigo.Text = "Código:";
            this.LBLcodigo.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(16, 55);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(47, 13);
            this.LBLnombre.TabIndex = 1;
            this.LBLnombre.Text = "Nombre:";
            // 
            // LBLdescripcion
            // 
            this.LBLdescripcion.AutoSize = true;
            this.LBLdescripcion.Location = new System.Drawing.Point(105, 180);
            this.LBLdescripcion.Name = "LBLdescripcion";
            this.LBLdescripcion.Size = new System.Drawing.Size(66, 13);
            this.LBLdescripcion.TabIndex = 2;
            this.LBLdescripcion.Text = "Descripcion:";
            // 
            // LBLmarca
            // 
            this.LBLmarca.AutoSize = true;
            this.LBLmarca.Location = new System.Drawing.Point(23, 86);
            this.LBLmarca.Name = "LBLmarca";
            this.LBLmarca.Size = new System.Drawing.Size(40, 13);
            this.LBLmarca.TabIndex = 3;
            this.LBLmarca.Text = "Marca:";
            this.LBLmarca.Click += new System.EventHandler(this.LBLmarca_Click);
            // 
            // LBLcategoria
            // 
            this.LBLcategoria.AutoSize = true;
            this.LBLcategoria.Location = new System.Drawing.Point(6, 117);
            this.LBLcategoria.Name = "LBLcategoria";
            this.LBLcategoria.Size = new System.Drawing.Size(57, 13);
            this.LBLcategoria.TabIndex = 4;
            this.LBLcategoria.Text = "Categoría:";
            // 
            // LBLprecio
            // 
            this.LBLprecio.AutoSize = true;
            this.LBLprecio.Location = new System.Drawing.Point(23, 149);
            this.LBLprecio.Name = "LBLprecio";
            this.LBLprecio.Size = new System.Drawing.Size(40, 13);
            this.LBLprecio.TabIndex = 5;
            this.LBLprecio.Text = "Precio:";
            // 
            // LBLimagen
            // 
            this.LBLimagen.AutoSize = true;
            this.LBLimagen.Location = new System.Drawing.Point(27, 285);
            this.LBLimagen.Name = "LBLimagen";
            this.LBLimagen.Size = new System.Drawing.Size(45, 13);
            this.LBLimagen.TabIndex = 6;
            this.LBLimagen.Text = "Imagen:";
            // 
            // TXBcodigo
            // 
            this.TXBcodigo.Location = new System.Drawing.Point(69, 21);
            this.TXBcodigo.Name = "TXBcodigo";
            this.TXBcodigo.Size = new System.Drawing.Size(191, 20);
            this.TXBcodigo.TabIndex = 7;
            // 
            // TXBnomnre
            // 
            this.TXBnomnre.Location = new System.Drawing.Point(69, 55);
            this.TXBnomnre.Name = "TXBnomnre";
            this.TXBnomnre.Size = new System.Drawing.Size(191, 20);
            this.TXBnomnre.TabIndex = 9;
            // 
            // CMBcategoria
            // 
            this.CMBcategoria.FormattingEnabled = true;
            this.CMBcategoria.Location = new System.Drawing.Point(69, 117);
            this.CMBcategoria.Name = "CMBcategoria";
            this.CMBcategoria.Size = new System.Drawing.Size(191, 21);
            this.CMBcategoria.TabIndex = 10;
            // 
            // CMBmarca
            // 
            this.CMBmarca.FormattingEnabled = true;
            this.CMBmarca.Location = new System.Drawing.Point(69, 86);
            this.CMBmarca.Name = "CMBmarca";
            this.CMBmarca.Size = new System.Drawing.Size(191, 21);
            this.CMBmarca.TabIndex = 11;
            // 
            // TXBprecio
            // 
            this.TXBprecio.Location = new System.Drawing.Point(69, 146);
            this.TXBprecio.Name = "TXBprecio";
            this.TXBprecio.Size = new System.Drawing.Size(191, 20);
            this.TXBprecio.TabIndex = 12;
            // 
            // PTBimagen
            // 
            this.PTBimagen.Location = new System.Drawing.Point(108, 255);
            this.PTBimagen.Name = "PTBimagen";
            this.PTBimagen.Size = new System.Drawing.Size(118, 107);
            this.PTBimagen.TabIndex = 13;
            this.PTBimagen.TabStop = false;
            // 
            // TXBdescripcion
            // 
            this.TXBdescripcion.Location = new System.Drawing.Point(9, 196);
            this.TXBdescripcion.Name = "TXBdescripcion";
            this.TXBdescripcion.Size = new System.Drawing.Size(251, 20);
            this.TXBdescripcion.TabIndex = 14;
            // 
            // LBLcargarImagen
            // 
            this.LBLcargarImagen.AutoSize = true;
            this.LBLcargarImagen.Location = new System.Drawing.Point(6, 228);
            this.LBLcargarImagen.Name = "LBLcargarImagen";
            this.LBLcargarImagen.Size = new System.Drawing.Size(78, 13);
            this.LBLcargarImagen.TabIndex = 15;
            this.LBLcargarImagen.Text = "Cargar imagen:";
            // 
            // TXBcargarImagen
            // 
            this.TXBcargarImagen.Location = new System.Drawing.Point(90, 225);
            this.TXBcargarImagen.Name = "TXBcargarImagen";
            this.TXBcargarImagen.Size = new System.Drawing.Size(170, 20);
            this.TXBcargarImagen.TabIndex = 16;
            // 
            // modificarArtículosToolStripMenuItem
            // 
            this.modificarArtículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.modificarArtículosToolStripMenuItem.Name = "modificarArtículosToolStripMenuItem";
            this.modificarArtículosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.modificarArtículosToolStripMenuItem.Text = "Agregar";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Categoría";
            // 
            // MSlistarArtículos
            // 
            this.MSlistarArtículos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porMarcaToolStripMenuItem,
            this.porCategoríaToolStripMenuItem});
            this.MSlistarArtículos.Name = "MSlistarArtículos";
            this.MSlistarArtículos.Size = new System.Drawing.Size(95, 20);
            this.MSlistarArtículos.Text = "Listar artículos";
            // 
            // porMarcaToolStripMenuItem
            // 
            this.porMarcaToolStripMenuItem.Name = "porMarcaToolStripMenuItem";
            this.porMarcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porMarcaToolStripMenuItem.Text = "Por marca";
            // 
            // porCategoríaToolStripMenuItem
            // 
            this.porCategoríaToolStripMenuItem.Name = "porCategoríaToolStripMenuItem";
            this.porCategoríaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porCategoríaToolStripMenuItem.Text = "Por categoría";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarArtículosToolStripMenuItem,
            this.MSlistarArtículos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MSTopciones";
            // 
            // BTNdetalle
            // 
            this.BTNdetalle.Location = new System.Drawing.Point(166, 81);
            this.BTNdetalle.Name = "BTNdetalle";
            this.BTNdetalle.Size = new System.Drawing.Size(75, 23);
            this.BTNdetalle.TabIndex = 5;
            this.BTNdetalle.Text = "Ver detalle";
            this.BTNdetalle.UseVisualStyleBackColor = true;
            // 
            // FRMmenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 423);
            this.Controls.Add(this.PBXeliminar);
            this.Controls.Add(this.GBXagregar);
            this.Controls.Add(this.GBXbuscar);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FRMmenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.FRMmenuPrincipal_Load);
            this.GBXbuscar.ResumeLayout(false);
            this.GBXbuscar.PerformLayout();
            this.GBXagregar.ResumeLayout(false);
            this.GBXagregar.PerformLayout();
            this.PBXeliminar.ResumeLayout(false);
            this.PBXeliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTBimagen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLbusqueda;
        private System.Windows.Forms.TextBox TXTbuscar;
        private System.Windows.Forms.ComboBox CMBbusqueda;
        private System.Windows.Forms.Button BTNbuscar;
        private System.Windows.Forms.GroupBox GBXbuscar;
        private System.Windows.Forms.GroupBox GBXagregar;
        private System.Windows.Forms.GroupBox PBXeliminar;
        private System.Windows.Forms.Button BTNeliminarPorCodigo;
        private System.Windows.Forms.Label LBLeliminarPorCodigo;
        private System.Windows.Forms.TextBox TXBeliminarPorCodigo;
        private System.Windows.Forms.Label LBLeliminarPorNombreYMarca;
        private System.Windows.Forms.Label LBLeliminarNombre;
        private System.Windows.Forms.Label LBLeliminarMarca;
        private System.Windows.Forms.TextBox TXBelimarMarca;
        private System.Windows.Forms.TextBox TXBelminarNombre;
        private System.Windows.Forms.Button BTNeliminarPorCodigoYMarca;
        private System.Windows.Forms.Label LBLimagen;
        private System.Windows.Forms.Label LBLprecio;
        private System.Windows.Forms.Label LBLcategoria;
        private System.Windows.Forms.Label LBLmarca;
        private System.Windows.Forms.Label LBLdescripcion;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Label LBLcodigo;
        private System.Windows.Forms.TextBox TXBnomnre;
        private System.Windows.Forms.TextBox TXBcodigo;
        private System.Windows.Forms.TextBox TXBprecio;
        private System.Windows.Forms.ComboBox CMBmarca;
        private System.Windows.Forms.ComboBox CMBcategoria;
        private System.Windows.Forms.TextBox TXBdescripcion;
        private System.Windows.Forms.PictureBox PTBimagen;
        private System.Windows.Forms.TextBox TXBcargarImagen;
        private System.Windows.Forms.Label LBLcargarImagen;
        private System.Windows.Forms.ToolStripMenuItem modificarArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MSlistarArtículos;
        private System.Windows.Forms.ToolStripMenuItem porMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCategoríaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button BTNdetalle;
    }
}

