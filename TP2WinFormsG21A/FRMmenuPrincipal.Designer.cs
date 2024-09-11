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
            this.BTNdetalle = new System.Windows.Forms.Button();
            this.GBXagregar = new System.Windows.Forms.GroupBox();
            this.TXBcargarImagen = new System.Windows.Forms.TextBox();
            this.LBLcargarImagen = new System.Windows.Forms.Label();
            this.TXBdescripcion = new System.Windows.Forms.TextBox();
            this.PTBimagen = new System.Windows.Forms.PictureBox();
            this.TXBprecio = new System.Windows.Forms.TextBox();
            this.CMBmarca = new System.Windows.Forms.ComboBox();
            this.CMBcategoria = new System.Windows.Forms.ComboBox();
            this.TXBnomnre = new System.Windows.Forms.TextBox();
            this.TXBcodigo = new System.Windows.Forms.TextBox();
            this.LBLimagen = new System.Windows.Forms.Label();
            this.LBLprecio = new System.Windows.Forms.Label();
            this.LBLcategoria = new System.Windows.Forms.Label();
            this.LBLmarca = new System.Windows.Forms.Label();
            this.LBLdescripcion = new System.Windows.Forms.Label();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.LBLcodigo = new System.Windows.Forms.Label();
            this.PBXeliminar = new System.Windows.Forms.GroupBox();
            this.BTNeliminarPorCodigoYMarca = new System.Windows.Forms.Button();
            this.TXBelimarMarca = new System.Windows.Forms.TextBox();
            this.TXBelminarNombre = new System.Windows.Forms.TextBox();
            this.LBLeliminarMarca = new System.Windows.Forms.Label();
            this.LBLeliminarNombre = new System.Windows.Forms.Label();
            this.LBLeliminarPorNombreYMarca = new System.Windows.Forms.Label();
            this.TXBeliminarPorCodigo = new System.Windows.Forms.TextBox();
            this.LBLeliminarPorCodigo = new System.Windows.Forms.Label();
            this.BTNeliminarPorCodigo = new System.Windows.Forms.Button();
            this.modificarArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSlistarArtículos = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.GBXbuscar.SuspendLayout();
            this.GBXagregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTBimagen)).BeginInit();
            this.PBXeliminar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLbusqueda
            // 
            this.LBLbusqueda.AutoSize = true;
            this.LBLbusqueda.Location = new System.Drawing.Point(9, 43);
            this.LBLbusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLbusqueda.Name = "LBLbusqueda";
            this.LBLbusqueda.Size = new System.Drawing.Size(190, 20);
            this.LBLbusqueda.TabIndex = 1;
            this.LBLbusqueda.Text = "Búsqueda de artículo por:";
            this.LBLbusqueda.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXTbuscar
            // 
            this.TXTbuscar.Location = new System.Drawing.Point(12, 85);
            this.TXTbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTbuscar.Name = "TXTbuscar";
            this.TXTbuscar.Size = new System.Drawing.Size(380, 26);
            this.TXTbuscar.TabIndex = 2;
            this.TXTbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CMBbusqueda
            // 
            this.CMBbusqueda.FormattingEnabled = true;
            this.CMBbusqueda.Location = new System.Drawing.Point(213, 38);
            this.CMBbusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBbusqueda.Name = "CMBbusqueda";
            this.CMBbusqueda.Size = new System.Drawing.Size(180, 28);
            this.CMBbusqueda.TabIndex = 3;
            this.CMBbusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BTNbuscar
            // 
            this.BTNbuscar.Location = new System.Drawing.Point(60, 125);
            this.BTNbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNbuscar.Name = "BTNbuscar";
            this.BTNbuscar.Size = new System.Drawing.Size(112, 35);
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
            this.GBXbuscar.Location = new System.Drawing.Point(18, 92);
            this.GBXbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBXbuscar.Name = "GBXbuscar";
            this.GBXbuscar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBXbuscar.Size = new System.Drawing.Size(422, 186);
            this.GBXbuscar.TabIndex = 5;
            this.GBXbuscar.TabStop = false;
            this.GBXbuscar.Text = "Buscar artículos";
            this.GBXbuscar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BTNdetalle
            // 
            this.BTNdetalle.Location = new System.Drawing.Point(249, 125);
            this.BTNdetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNdetalle.Name = "BTNdetalle";
            this.BTNdetalle.Size = new System.Drawing.Size(112, 35);
            this.BTNdetalle.TabIndex = 5;
            this.BTNdetalle.Text = "Ver detalle";
            this.BTNdetalle.UseVisualStyleBackColor = true;
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
            this.GBXagregar.Location = new System.Drawing.Point(462, 92);
            this.GBXagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBXagregar.Name = "GBXagregar";
            this.GBXagregar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBXagregar.Size = new System.Drawing.Size(422, 583);
            this.GBXagregar.TabIndex = 6;
            this.GBXagregar.TabStop = false;
            this.GBXagregar.Text = "Agregar artículo";
            // 
            // TXBcargarImagen
            // 
            this.TXBcargarImagen.Location = new System.Drawing.Point(135, 346);
            this.TXBcargarImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXBcargarImagen.Name = "TXBcargarImagen";
            this.TXBcargarImagen.Size = new System.Drawing.Size(253, 26);
            this.TXBcargarImagen.TabIndex = 16;
            // 
            // LBLcargarImagen
            // 
            this.LBLcargarImagen.AutoSize = true;
            this.LBLcargarImagen.Location = new System.Drawing.Point(9, 351);
            this.LBLcargarImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLcargarImagen.Name = "LBLcargarImagen";
            this.LBLcargarImagen.Size = new System.Drawing.Size(117, 20);
            this.LBLcargarImagen.TabIndex = 15;
            this.LBLcargarImagen.Text = "Cargar imagen:";
            // 
            // TXBdescripcion
            // 
            this.TXBdescripcion.Location = new System.Drawing.Point(14, 302);
            this.TXBdescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXBdescripcion.Name = "TXBdescripcion";
            this.TXBdescripcion.Size = new System.Drawing.Size(374, 26);
            this.TXBdescripcion.TabIndex = 14;
            // 
            // PTBimagen
            // 
            this.PTBimagen.Location = new System.Drawing.Point(162, 392);
            this.PTBimagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PTBimagen.Name = "PTBimagen";
            this.PTBimagen.Size = new System.Drawing.Size(177, 165);
            this.PTBimagen.TabIndex = 13;
            this.PTBimagen.TabStop = false;
            // 
            // TXBprecio
            // 
            this.TXBprecio.Location = new System.Drawing.Point(104, 225);
            this.TXBprecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXBprecio.Name = "TXBprecio";
            this.TXBprecio.Size = new System.Drawing.Size(284, 26);
            this.TXBprecio.TabIndex = 12;
            // 
            // CMBmarca
            // 
            this.CMBmarca.FormattingEnabled = true;
            this.CMBmarca.Location = new System.Drawing.Point(104, 132);
            this.CMBmarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBmarca.Name = "CMBmarca";
            this.CMBmarca.Size = new System.Drawing.Size(284, 28);
            this.CMBmarca.TabIndex = 11;
            // 
            // CMBcategoria
            // 
            this.CMBcategoria.FormattingEnabled = true;
            this.CMBcategoria.Location = new System.Drawing.Point(104, 180);
            this.CMBcategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBcategoria.Name = "CMBcategoria";
            this.CMBcategoria.Size = new System.Drawing.Size(284, 28);
            this.CMBcategoria.TabIndex = 10;
            // 
            // TXBnomnre
            // 
            this.TXBnomnre.Location = new System.Drawing.Point(104, 85);
            this.TXBnomnre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXBnomnre.Name = "TXBnomnre";
            this.TXBnomnre.Size = new System.Drawing.Size(284, 26);
            this.TXBnomnre.TabIndex = 9;
            // 
            // TXBcodigo
            // 
            this.TXBcodigo.Location = new System.Drawing.Point(104, 32);
            this.TXBcodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXBcodigo.Name = "TXBcodigo";
            this.TXBcodigo.Size = new System.Drawing.Size(284, 26);
            this.TXBcodigo.TabIndex = 7;
            // 
            // LBLimagen
            // 
            this.LBLimagen.AutoSize = true;
            this.LBLimagen.Location = new System.Drawing.Point(40, 438);
            this.LBLimagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLimagen.Name = "LBLimagen";
            this.LBLimagen.Size = new System.Drawing.Size(67, 20);
            this.LBLimagen.TabIndex = 6;
            this.LBLimagen.Text = "Imagen:";
            // 
            // LBLprecio
            // 
            this.LBLprecio.AutoSize = true;
            this.LBLprecio.Location = new System.Drawing.Point(34, 229);
            this.LBLprecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLprecio.Name = "LBLprecio";
            this.LBLprecio.Size = new System.Drawing.Size(57, 20);
            this.LBLprecio.TabIndex = 5;
            this.LBLprecio.Text = "Precio:";
            // 
            // LBLcategoria
            // 
            this.LBLcategoria.AutoSize = true;
            this.LBLcategoria.Location = new System.Drawing.Point(9, 180);
            this.LBLcategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLcategoria.Name = "LBLcategoria";
            this.LBLcategoria.Size = new System.Drawing.Size(82, 20);
            this.LBLcategoria.TabIndex = 4;
            this.LBLcategoria.Text = "Categoría:";
            // 
            // LBLmarca
            // 
            this.LBLmarca.AutoSize = true;
            this.LBLmarca.Location = new System.Drawing.Point(34, 132);
            this.LBLmarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLmarca.Name = "LBLmarca";
            this.LBLmarca.Size = new System.Drawing.Size(57, 20);
            this.LBLmarca.TabIndex = 3;
            this.LBLmarca.Text = "Marca:";
            this.LBLmarca.Click += new System.EventHandler(this.LBLmarca_Click);
            // 
            // LBLdescripcion
            // 
            this.LBLdescripcion.AutoSize = true;
            this.LBLdescripcion.Location = new System.Drawing.Point(158, 277);
            this.LBLdescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLdescripcion.Name = "LBLdescripcion";
            this.LBLdescripcion.Size = new System.Drawing.Size(96, 20);
            this.LBLdescripcion.TabIndex = 2;
            this.LBLdescripcion.Text = "Descripcion:";
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(24, 85);
            this.LBLnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(69, 20);
            this.LBLnombre.TabIndex = 1;
            this.LBLnombre.Text = "Nombre:";
            // 
            // LBLcodigo
            // 
            this.LBLcodigo.AutoSize = true;
            this.LBLcodigo.Location = new System.Drawing.Point(30, 38);
            this.LBLcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLcodigo.Name = "LBLcodigo";
            this.LBLcodigo.Size = new System.Drawing.Size(63, 20);
            this.LBLcodigo.TabIndex = 0;
            this.LBLcodigo.Text = "Código:";
            this.LBLcodigo.Click += new System.EventHandler(this.label1_Click_3);
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
            this.PBXeliminar.Location = new System.Drawing.Point(18, 305);
            this.PBXeliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PBXeliminar.Name = "PBXeliminar";
            this.PBXeliminar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PBXeliminar.Size = new System.Drawing.Size(422, 371);
            this.PBXeliminar.TabIndex = 7;
            this.PBXeliminar.TabStop = false;
            this.PBXeliminar.Text = "Eliminar artículos";
            // 
            // BTNeliminarPorCodigoYMarca
            // 
            this.BTNeliminarPorCodigoYMarca.Location = new System.Drawing.Point(142, 266);
            this.BTNeliminarPorCodigoYMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNeliminarPorCodigoYMarca.Name = "BTNeliminarPorCodigoYMarca";
            this.BTNeliminarPorCodigoYMarca.Size = new System.Drawing.Size(112, 35);
            this.BTNeliminarPorCodigoYMarca.TabIndex = 11;
            this.BTNeliminarPorCodigoYMarca.Text = "Eliminar";
            this.BTNeliminarPorCodigoYMarca.UseVisualStyleBackColor = true;
            // 
            // TXBelimarMarca
            // 
            this.TXBelimarMarca.Location = new System.Drawing.Point(279, 211);
            this.TXBelimarMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXBelimarMarca.Name = "TXBelimarMarca";
            this.TXBelimarMarca.Size = new System.Drawing.Size(114, 26);
            this.TXBelimarMarca.TabIndex = 10;
            // 
            // TXBelminarNombre
            // 
            this.TXBelminarNombre.Location = new System.Drawing.Point(90, 211);
            this.TXBelminarNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXBelminarNombre.Name = "TXBelminarNombre";
            this.TXBelminarNombre.Size = new System.Drawing.Size(114, 26);
            this.TXBelminarNombre.TabIndex = 9;
            // 
            // LBLeliminarMarca
            // 
            this.LBLeliminarMarca.AutoSize = true;
            this.LBLeliminarMarca.Location = new System.Drawing.Point(210, 215);
            this.LBLeliminarMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLeliminarMarca.Name = "LBLeliminarMarca";
            this.LBLeliminarMarca.Size = new System.Drawing.Size(57, 20);
            this.LBLeliminarMarca.TabIndex = 8;
            this.LBLeliminarMarca.Text = "Marca:";
            this.LBLeliminarMarca.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // LBLeliminarNombre
            // 
            this.LBLeliminarNombre.AutoSize = true;
            this.LBLeliminarNombre.Location = new System.Drawing.Point(10, 215);
            this.LBLeliminarNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLeliminarNombre.Name = "LBLeliminarNombre";
            this.LBLeliminarNombre.Size = new System.Drawing.Size(69, 20);
            this.LBLeliminarNombre.TabIndex = 7;
            this.LBLeliminarNombre.Text = "Nombre:";
            this.LBLeliminarNombre.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LBLeliminarPorNombreYMarca
            // 
            this.LBLeliminarPorNombreYMarca.AutoSize = true;
            this.LBLeliminarPorNombreYMarca.Location = new System.Drawing.Point(98, 174);
            this.LBLeliminarPorNombreYMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLeliminarPorNombreYMarca.Name = "LBLeliminarPorNombreYMarca";
            this.LBLeliminarPorNombreYMarca.Size = new System.Drawing.Size(209, 20);
            this.LBLeliminarPorNombreYMarca.TabIndex = 6;
            this.LBLeliminarPorNombreYMarca.Text = "Eliminar por nombre y marca";
            // 
            // TXBeliminarPorCodigo
            // 
            this.TXBeliminarPorCodigo.Location = new System.Drawing.Point(166, 34);
            this.TXBeliminarPorCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXBeliminarPorCodigo.Name = "TXBeliminarPorCodigo";
            this.TXBeliminarPorCodigo.Size = new System.Drawing.Size(226, 26);
            this.TXBeliminarPorCodigo.TabIndex = 5;
            this.TXBeliminarPorCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LBLeliminarPorCodigo
            // 
            this.LBLeliminarPorCodigo.AutoSize = true;
            this.LBLeliminarPorCodigo.Location = new System.Drawing.Point(9, 38);
            this.LBLeliminarPorCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLeliminarPorCodigo.Name = "LBLeliminarPorCodigo";
            this.LBLeliminarPorCodigo.Size = new System.Drawing.Size(147, 20);
            this.LBLeliminarPorCodigo.TabIndex = 1;
            this.LBLeliminarPorCodigo.Text = "Eliminar por código:";
            // 
            // BTNeliminarPorCodigo
            // 
            this.BTNeliminarPorCodigo.Location = new System.Drawing.Point(142, 74);
            this.BTNeliminarPorCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNeliminarPorCodigo.Name = "BTNeliminarPorCodigo";
            this.BTNeliminarPorCodigo.Size = new System.Drawing.Size(112, 35);
            this.BTNeliminarPorCodigo.TabIndex = 0;
            this.BTNeliminarPorCodigo.Text = "Eliminar";
            this.BTNeliminarPorCodigo.UseVisualStyleBackColor = true;
            // 
            // modificarArtículosToolStripMenuItem
            // 
            this.modificarArtículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.modificarArtículosToolStripMenuItem.Name = "modificarArtículosToolStripMenuItem";
            this.modificarArtículosToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.modificarArtículosToolStripMenuItem.Text = "Agregar";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.categoriaToolStripMenuItem.Text = "Categoría";
            // 
            // MSlistarArtículos
            // 
            this.MSlistarArtículos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosArtículosToolStripMenuItem,
            this.porMarcaToolStripMenuItem,
            this.porCategoríaToolStripMenuItem});
            this.MSlistarArtículos.Name = "MSlistarArtículos";
            this.MSlistarArtículos.Size = new System.Drawing.Size(140, 29);
            this.MSlistarArtículos.Text = "Listar artículos";
            this.MSlistarArtículos.Click += new System.EventHandler(this.MSlistarArtículos_Click);
            // 
            // todosLosArtículosToolStripMenuItem
            // 
            this.todosLosArtículosToolStripMenuItem.Name = "todosLosArtículosToolStripMenuItem";
            this.todosLosArtículosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.todosLosArtículosToolStripMenuItem.Text = "Todos los artículos";
            this.todosLosArtículosToolStripMenuItem.Click += new System.EventHandler(this.todosLosArtículosToolStripMenuItem_Click);
            // 
            // porMarcaToolStripMenuItem
            // 
            this.porMarcaToolStripMenuItem.Name = "porMarcaToolStripMenuItem";
            this.porMarcaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.porMarcaToolStripMenuItem.Text = "Por marca";
            this.porMarcaToolStripMenuItem.Click += new System.EventHandler(this.porMarcaToolStripMenuItem_Click);
            // 
            // porCategoríaToolStripMenuItem
            // 
            this.porCategoríaToolStripMenuItem.Name = "porCategoríaToolStripMenuItem";
            this.porCategoríaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.porCategoríaToolStripMenuItem.Text = "Por categoría";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarArtículosToolStripMenuItem,
            this.MSlistarArtículos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MSTopciones";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(906, 34);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(179, 29);
            this.toolStripButton1.Text = "Modificar un artículo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FRMmenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(906, 689);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PBXeliminar);
            this.Controls.Add(this.GBXagregar);
            this.Controls.Add(this.GBXbuscar);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMmenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.FRMmenuPrincipal_Load);
            this.GBXbuscar.ResumeLayout(false);
            this.GBXbuscar.PerformLayout();
            this.GBXagregar.ResumeLayout(false);
            this.GBXagregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTBimagen)).EndInit();
            this.PBXeliminar.ResumeLayout(false);
            this.PBXeliminar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem todosLosArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

