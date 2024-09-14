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
    public partial class FRMlistaTodosArticulos : Form
    {
        List<Articulo> listaArticulo = new List<Articulo>();
        public FRMlistaTodosArticulos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRMlistaTodosArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void DGVlistaTodosArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)DGVlistaTodosArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.ImagenUrl);
        }

        private void cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listar();
                DGVlistaTodosArticulos.DataSource = listaArticulo;
                cargarImagen(listaArticulo[0].Imagen.ImagenUrl);
                DGVlistaTodosArticulos.Columns["Imagen"].Visible = false;
                DGVlistaTodosArticulos.Columns["Categoria"].Visible = false;
                DGVlistaTodosArticulos.Columns["Marca"].Visible = false;

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
                PTBimagen.Load(imagen);
            }
            catch (Exception ex)
            {

                PTBimagen.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    ArticuloNegocio negocioArticulo = new ArticuloNegocio();
                    Articulo seleccionado;

                    seleccionado = (Articulo)DGVlistaTodosArticulos.CurrentRow.DataBoundItem;
                    negocioArticulo.eliminar(seleccionado.Codigo);
                    cargar();
                }

             
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
