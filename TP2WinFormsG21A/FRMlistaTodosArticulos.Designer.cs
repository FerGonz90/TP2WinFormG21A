namespace TP2WinFormsG21A
{
    partial class FRMlistaTodosArticulos
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
            this.DGVlistaTodosArticulos = new System.Windows.Forms.DataGridView();
            this.PTBimagen = new System.Windows.Forms.PictureBox();
            this.BTNmodificar = new System.Windows.Forms.Button();
            this.BTNeliminar = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistaTodosArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTBimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVlistaTodosArticulos
            // 
            this.DGVlistaTodosArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVlistaTodosArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVlistaTodosArticulos.Location = new System.Drawing.Point(0, 0);
            this.DGVlistaTodosArticulos.Name = "DGVlistaTodosArticulos";
            this.DGVlistaTodosArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVlistaTodosArticulos.Size = new System.Drawing.Size(671, 242);
            this.DGVlistaTodosArticulos.TabIndex = 0;
            this.DGVlistaTodosArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGVlistaTodosArticulos.SelectionChanged += new System.EventHandler(this.DGVlistaTodosArticulos_SelectionChanged);
            // 
            // PTBimagen
            // 
            this.PTBimagen.Location = new System.Drawing.Point(677, 0);
            this.PTBimagen.Name = "PTBimagen";
            this.PTBimagen.Size = new System.Drawing.Size(241, 242);
            this.PTBimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PTBimagen.TabIndex = 1;
            this.PTBimagen.TabStop = false;
            this.PTBimagen.RegionChanged += new System.EventHandler(this.DGVlistaTodosArticulos_SelectionChanged);
            // 
            // BTNmodificar
            // 
            this.BTNmodificar.Location = new System.Drawing.Point(33, 248);
            this.BTNmodificar.Name = "BTNmodificar";
            this.BTNmodificar.Size = new System.Drawing.Size(91, 39);
            this.BTNmodificar.TabIndex = 2;
            this.BTNmodificar.Text = "Modificar";
            this.BTNmodificar.UseVisualStyleBackColor = true;
            // 
            // BTNeliminar
            // 
            this.BTNeliminar.Location = new System.Drawing.Point(199, 248);
            this.BTNeliminar.Name = "BTNeliminar";
            this.BTNeliminar.Size = new System.Drawing.Size(91, 39);
            this.BTNeliminar.TabIndex = 3;
            this.BTNeliminar.Text = "Eliminar";
            this.BTNeliminar.UseVisualStyleBackColor = true;
            this.BTNeliminar.Click += new System.EventHandler(this.BTNeliminar_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(358, 248);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(91, 39);
            this.btnVerDetalle.TabIndex = 4;
            this.btnVerDetalle.Text = "Ver detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // FRMlistaTodosArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 365);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.BTNeliminar);
            this.Controls.Add(this.BTNmodificar);
            this.Controls.Add(this.PTBimagen);
            this.Controls.Add(this.DGVlistaTodosArticulos);
            this.Name = "FRMlistaTodosArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de todos los articulos";
            this.Load += new System.EventHandler(this.FRMlistaTodosArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistaTodosArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTBimagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVlistaTodosArticulos;
        private System.Windows.Forms.PictureBox PTBimagen;
        private System.Windows.Forms.Button BTNmodificar;
        private System.Windows.Forms.Button BTNeliminar;
        private System.Windows.Forms.Button btnVerDetalle;
    }
}