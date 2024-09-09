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
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistaTodosArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVlistaTodosArticulos
            // 
            this.DGVlistaTodosArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVlistaTodosArticulos.Location = new System.Drawing.Point(0, 0);
            this.DGVlistaTodosArticulos.Name = "DGVlistaTodosArticulos";
            this.DGVlistaTodosArticulos.Size = new System.Drawing.Size(788, 242);
            this.DGVlistaTodosArticulos.TabIndex = 0;
            this.DGVlistaTodosArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FRMlistaTodosArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVlistaTodosArticulos);
            this.Name = "FRMlistaTodosArticulos";
            this.Text = "Lista de todos los articulos";
            this.Load += new System.EventHandler(this.FRMlistaTodosArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistaTodosArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVlistaTodosArticulos;
    }
}