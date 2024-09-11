namespace TP2WinFormsG21A
{
    partial class frmListadoMarcas
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
            this.dgvListadoMarcas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoMarcas
            // 
            this.dgvListadoMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoMarcas.Location = new System.Drawing.Point(0, 0);
            this.dgvListadoMarcas.Name = "dgvListadoMarcas";
            this.dgvListadoMarcas.RowHeadersWidth = 62;
            this.dgvListadoMarcas.RowTemplate.Height = 28;
            this.dgvListadoMarcas.Size = new System.Drawing.Size(772, 344);
            this.dgvListadoMarcas.TabIndex = 0;
            // 
            // frmListadoMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListadoMarcas);
            this.Name = "frmListadoMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Marcas";
            this.Load += new System.EventHandler(this.frmListadoMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoMarcas;
    }
}