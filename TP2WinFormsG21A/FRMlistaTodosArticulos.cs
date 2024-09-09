using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2WinFormsG21A
{
    public partial class FRMlistaTodosArticulos : Form
    {
        public FRMlistaTodosArticulos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRMlistaTodosArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            DGVlistaTodosArticulos.DataSource = negocio.listar();
        }
    }
}
