namespace TP2WinFormsG21A
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MSlistarArtículos = new System.Windows.Forms.ToolStripMenuItem();
            this.porMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBLbusqueda = new System.Windows.Forms.Label();
            this.TXTbuscar = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSlistarArtículos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // LBLbusqueda
            // 
            this.LBLbusqueda.AutoSize = true;
            this.LBLbusqueda.Location = new System.Drawing.Point(34, 89);
            this.LBLbusqueda.Name = "LBLbusqueda";
            this.LBLbusqueda.Size = new System.Drawing.Size(130, 13);
            this.LBLbusqueda.TabIndex = 1;
            this.LBLbusqueda.Text = "Búsqueda de artículo por:";
            this.LBLbusqueda.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXTbuscar
            // 
            this.TXTbuscar.Location = new System.Drawing.Point(36, 116);
            this.TXTbuscar.Name = "TXTbuscar";
            this.TXTbuscar.Size = new System.Drawing.Size(255, 20);
            this.TXTbuscar.TabIndex = 2;
            this.TXTbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TXTbuscar);
            this.Controls.Add(this.LBLbusqueda);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MSlistarArtículos;
        private System.Windows.Forms.ToolStripMenuItem porMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCategoríaToolStripMenuItem;
        private System.Windows.Forms.Label LBLbusqueda;
        private System.Windows.Forms.TextBox TXTbuscar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

