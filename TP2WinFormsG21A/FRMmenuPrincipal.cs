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
            cargar();  
        }

        private void porMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListArtPorMarca ventanaListArtMarcas = new frmListArtPorMarca();
            ventanaListArtMarcas.ShowDialog();
        }

        private void todosLosArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMlistaTodosArticulos ventanaListaTodosArticulos = new FRMlistaTodosArticulos();
            ventanaListaTodosArticulos.ShowDialog();
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

        private void listarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoMarcas ventanaListadoMarcas = new frmListadoMarcas();
            ventanaListadoMarcas.ShowDialog();
        }

        private void CMBmarca_DropDown(object sender, EventArgs e)
        {
            //cargarMarca();
        }
        private void CMBcategoria_DropDown(object sender, EventArgs e)
        {
            //cargarCategoria();
        }

        /*private void cargarMarca()
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            try
            {
                CMBmarca.DataSource = negocioMarca.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarCategoria()
        {
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            try
            {
                CMBcategoria.DataSource = negocioCategoria.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }*/

        private void cargar()
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();

            try
            {
                CMBmarca.DataSource = negocioMarca.listar();
                CMBcategoria.DataSource = negocioCategoria.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();

            try
            {
                articulo.Codigo = TXBcodigo.Text;
                articulo.Nombre = TXBnomnre.Text;
                articulo.Descripcion = TXBdescripcion.Text;
                articulo.Precio = decimal.Parse(TXBprecio.Text);
                articulo.Marca = (Marca)CMBmarca.SelectedItem;
                articulo.Categoria = (Categoria)CMBcategoria.SelectedItem;
                articulo.Imagen = new Imagen();
                articulo.Imagen._Imagen = TXBcargarImagen.Text;

                negocioArticulo.agregar(articulo);
                MessageBox.Show("Articulo agregado");
                cargar();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void TXBcargarImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(TXBcargarImagen.Text);
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

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarca ventanaAgregarMarca = new frmAgregarMarca();
            ventanaAgregarMarca.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria ventanaAgregarCategoria = new frmAgregarCategoria();
            ventanaAgregarCategoria.ShowDialog();
        }
    }
}
