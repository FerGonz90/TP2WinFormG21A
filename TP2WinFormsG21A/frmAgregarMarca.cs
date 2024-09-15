using dominio;
using negocio;
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
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                nuevaMarca.NombreMarca = tbxMarca.Text;

                negocio.agregar(nuevaMarca);
                MessageBox.Show("Marca agregada");
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
