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
    public partial class frmDetalle : Form
    {
        List<Articulo> listaArticulo = new List<Articulo>();
        public frmDetalle()
        {
            InitializeComponent();
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            cargarDetalle();
        }

        
        private void cargarDetalle()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listarDetalle();
                dgvDetallesArticulos.DataSource = listaArticulo;
                cargarImagen(listaArticulo[0].Imagen.ImagenUrl);
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                ptbImagenDetalle.Load(imagen);
            }
            catch (Exception ex)
            {

                ptbImagenDetalle.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }


    }
}
