using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;


namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar() {

            List<Articulo> listaArticulo = new List<Articulo>();
            AccesoDatos datosArticulo = new AccesoDatos();

            try
            {
                datosArticulo.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, IdMarca, IdCategoria, Precio, I.IdArticulo, ImagenUrl From ARTICULOS A, IMAGENES I WHERE A.Id = I.IdArticulo");
                datosArticulo.ejecutarLectura();

                while (datosArticulo.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datosArticulo.Lector["Codigo"];
                    aux.Nombre = (string)datosArticulo.Lector["Nombre"];
                    aux.Descripcion = (string)datosArticulo.Lector["Descripcion"];
                   /// aux.Marca = new Marca();
                   /// aux.Marca.IdMarca = (int)datosArticulo.Lector["IdMarca"];
                    //aux.Categoria = (int)datosArticulo.Lector["IdCategoria"];
                    aux.Precio = (decimal)datosArticulo.Lector["Precio"];
                    aux.Imagen = new Imagen();
                    aux.Imagen.Id = (int)datosArticulo.Lector["Id"];
                    aux.Imagen._Imagen = (string)datosArticulo.Lector["ImagenUrl"];

                    listaArticulo.Add(aux);
                }


                return listaArticulo;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

            finally
            {
                datosArticulo.cerrarConexion();
            }
        
        }

        public void agregar (Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria, ImagenUrl) values (" + nuevo.Codigo + ", '" + nuevo.Nombre + "','" + nuevo.Descripcion + "'," + nuevo.Precio + ", @IdMarca, @IdCategoria, @ImagenUrl)");
                datos.setearParametro("@IdMarca", nuevo.Marca.IdMarca);
                datos.setearParametro("@Idcategoria", nuevo.Categoria.IdCat);
                datos.setearParametro("@ImagenUrl", nuevo.Imagen._Imagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Articulo> ArtFiltroMarca(int marcaId)
        {
            List<Articulo> filtroMarca = new List<Articulo>();
            AccesoDatos datos2 = new AccesoDatos();

            try
            {
                datos2.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, IdMarca, IdCategoria, Precio, I.IdArticulo, ImagenUrl From ARTICULOS A, IMAGENES I WHERE A.Id = I.IdArticulo and A.IdMarca = @MarcaId");
                datos2.setearParametro("@MarcaId", marcaId);
                datos2.ejecutarLectura();

                while (datos2.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos2.Lector["Codigo"];
                    aux.Nombre = (string)datos2.Lector["Nombre"];
                    aux.Descripcion = (string)datos2.Lector["Descripcion"];
                    aux.Precio = (decimal)datos2.Lector["Precio"];
                    aux.Imagen = new Imagen();
                    aux.Imagen.Id = (int)datos2.Lector["Id"];
                    aux.Imagen._Imagen = (string)datos2.Lector["ImagenUrl"];

                    filtroMarca.Add(aux);
                }

                return filtroMarca;
            }

            catch (Exception Ex)
            {
                throw Ex;
            }

            finally
            {
                datos2.cerrarConexion();
            }
        }
        public void eliminar(string codigo)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where Codigo = @codigo");
                datos.setearParametro("@codigo", codigo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
