using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace TP2WinFormsG21A
{
    public partial class FRMmenuPrincipal : Form
    {
        public FRMmenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void LBLmarca_Click(object sender, EventArgs e)
        {

        }

        private void FRMmenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void porMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoMarcas ventanaListadoMarcas = new frmListadoMarcas();
            ventanaListadoMarcas.Show();
        }

        private void todosLosArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMlistaTodosArticulos ventanaListaTodosArticulos = new FRMlistaTodosArticulos();
            ventanaListaTodosArticulos.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void MSlistarArtículos_Click(object sender, EventArgs e)
        {

        }

        private void CMBmarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXBnomnre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
