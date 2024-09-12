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
using negocio;

namespace TP2WinFormsG21A
{
    public partial class frmListArtPorMarca : Form
    {
        public frmListArtPorMarca()
        {
            InitializeComponent();
        }

        private void frmListArtPorMarca_Load(object sender, EventArgs e)
        {

        }

        private void cbxListMarcas_DropDown(object sender, EventArgs e)
        {
            cbxListMarcas.Items.Clear();

            CargarMarcas();
        }

        private void CargarMarcas()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> listaMarcas = marcaNegocio.listar();

            foreach (Marca marca in listaMarcas)
            {
                cbxListMarcas.Items.Add(marca.NombreMarca);
            }
        }
    }
}
