namespace TP2WinFormsG21A
{
    partial class frmListArtPorMarca
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvListArtPorMarca = new System.Windows.Forms.DataGridView();
            this.cbxListMarcas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListArtPorMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(116, 40);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(71, 20);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "MARCA:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(401, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvListArtPorMarca
            // 
            this.dgvListArtPorMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListArtPorMarca.Location = new System.Drawing.Point(41, 105);
            this.dgvListArtPorMarca.Name = "dgvListArtPorMarca";
            this.dgvListArtPorMarca.RowHeadersWidth = 62;
            this.dgvListArtPorMarca.RowTemplate.Height = 28;
            this.dgvListArtPorMarca.Size = new System.Drawing.Size(703, 299);
            this.dgvListArtPorMarca.TabIndex = 3;
            // 
            // cbxListMarcas
            // 
            this.cbxListMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListMarcas.FormattingEnabled = true;
            this.cbxListMarcas.Location = new System.Drawing.Point(228, 32);
            this.cbxListMarcas.MaxDropDownItems = 18;
            this.cbxListMarcas.Name = "cbxListMarcas";
            this.cbxListMarcas.Size = new System.Drawing.Size(121, 28);
            this.cbxListMarcas.Sorted = true;
            this.cbxListMarcas.TabIndex = 4;
            this.cbxListMarcas.DropDown += new System.EventHandler(this.cbxListMarcas_DropDown);
            // 
            // frmListArtPorMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxListMarcas);
            this.Controls.Add(this.dgvListArtPorMarca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblMarca);
            this.Name = "frmListArtPorMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de articulos de una marca";
            this.Load += new System.EventHandler(this.frmListArtPorMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListArtPorMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvListArtPorMarca;
        private System.Windows.Forms.ComboBox cbxListMarcas;
    }
}