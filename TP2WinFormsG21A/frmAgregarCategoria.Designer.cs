namespace TP2WinFormsG21A
{
    partial class frmAgregarCategoria
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
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(316, 205);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(157, 45);
            this.btnAgregarMarca.TabIndex = 0;
            this.btnAgregarMarca.Text = "AGREGAR";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // tbxMarca
            // 
            this.tbxMarca.Location = new System.Drawing.Point(316, 111);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(157, 26);
            this.tbxMarca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la Categoria:";
            // 
            // frmAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Name = "frmAgregarCategoria";
            this.Text = "Nueva Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.Label label1;
    }
}