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
        int DatoRecibido;
        string ImagenRecibida;
        public frmDetalle(int Id, string imagen)
        {
            InitializeComponent();
            DatoRecibido = Id;
            ImagenRecibida = imagen;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            cargarDetalle(DatoRecibido, ImagenRecibida);
        }




        private void cargarDetalle(int Id, string imagen)
        {
            try
            {            
                
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listarDetalle(Id);
                dgvDetallesArticulos.DataSource = listaArticulo;
                cargarImagen(imagen);
               
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
