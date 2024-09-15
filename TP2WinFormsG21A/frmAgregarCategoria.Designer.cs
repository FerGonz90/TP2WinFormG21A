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
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.tbxCategoria = new System.Windows.Forms.TextBox();
            this.lblNombraCategoria = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(316, 205);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(157, 45);
            this.btnAgregarCategoria.TabIndex = 0;
            this.btnAgregarCategoria.Text = "AGREGAR";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // tbxCategoria
            // 
            this.tbxCategoria.Location = new System.Drawing.Point(316, 111);
            this.tbxCategoria.Name = "tbxCategoria";
            this.tbxCategoria.Size = new System.Drawing.Size(157, 26);
            this.tbxCategoria.TabIndex = 1;
            // 
            // lblNombraCategoria
            // 
            this.lblNombraCategoria.AutoSize = true;
            this.lblNombraCategoria.Location = new System.Drawing.Point(130, 114);
            this.lblNombraCategoria.Name = "lblNombraCategoria";
            this.lblNombraCategoria.Size = new System.Drawing.Size(180, 20);
            this.lblNombraCategoria.TabIndex = 2;
            this.lblNombraCategoria.Text = "Nombre de la Categoria:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(316, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 44);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 478);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblNombraCategoria);
            this.Controls.Add(this.tbxCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Name = "frmAgregarCategoria";
            this.Text = "Nueva Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox tbxCategoria;
        private System.Windows.Forms.Label lblNombraCategoria;
        private System.Windows.Forms.Button btnCancelar;
    }
}