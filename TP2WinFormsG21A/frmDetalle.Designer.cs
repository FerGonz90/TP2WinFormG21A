namespace TP2WinFormsG21A
{
    partial class frmDetalle
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
            this.dgvDetallesArticulos = new System.Windows.Forms.DataGridView();
            this.ptbImagenDetalle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetallesArticulos
            // 
            this.dgvDetallesArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetallesArticulos.Location = new System.Drawing.Point(12, 12);
            this.dgvDetallesArticulos.Name = "dgvDetallesArticulos";
            this.dgvDetallesArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallesArticulos.Size = new System.Drawing.Size(1082, 100);
            this.dgvDetallesArticulos.TabIndex = 1;
            // 
            // ptbImagenDetalle
            // 
            this.ptbImagenDetalle.Location = new System.Drawing.Point(362, 131);
            this.ptbImagenDetalle.Name = "ptbImagenDetalle";
            this.ptbImagenDetalle.Size = new System.Drawing.Size(353, 337);
            this.ptbImagenDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagenDetalle.TabIndex = 2;
            this.ptbImagenDetalle.TabStop = false;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 480);
            this.Controls.Add(this.ptbImagenDetalle);
            this.Controls.Add(this.dgvDetallesArticulos);
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de artículos";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetallesArticulos;
        private System.Windows.Forms.PictureBox ptbImagenDetalle;
    }
}