﻿using System;
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
                    aux.Precio = (decimal)datosArticulo.Lector["Precio"];
                    aux.Imagen = new Imagen();
                    aux.Imagen.Id = (int)datosArticulo.Lector["Id"];
                    aux.Imagen.ImagenUrl = (string)datosArticulo.Lector["ImagenUrl"];

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

        public List<Articulo> listarDetalle()
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            AccesoDatos datosArticulo = new AccesoDatos();
            try
            {
                datosArticulo.setearConsulta("SELECT A.Id AS 'ArticuloId', Codigo, Nombre, M.Descripcion AS 'MarcaDescripcion', C.Descripcion AS 'CategoriaDescripcion', A.Descripcion AS 'ArticuloDescripcion', IdMarca, IdCategoria, Precio, C.Id AS 'CategoriaId', I.Id AS 'ImagenId', I.IdArticulo AS 'ImagenIdArticulo', ImagenUrl,  M.Id AS 'MarcaId' FROM ARTICULOS A JOIN CATEGORIAS C ON A.IdCategoria = C.Id JOIN MARCAS M ON A.IdMarca = M.Id  JOIN IMAGENES I ON A.Id = I.IdArticulo WHERE a.Id = 3");
                datosArticulo.ejecutarLectura();

                while (datosArticulo.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Imagen = new Imagen();
                    aux.Categoria = new Categoria();
                    aux.Id = (int)datosArticulo.Lector["ArticuloId"];
                    aux.Codigo = (string)datosArticulo.Lector["Codigo"];
                    aux.Nombre = (string)datosArticulo.Lector["Nombre"];
                    aux.Marca.NombreMarca = (string)datosArticulo.Lector["MarcaDescripcion"];
                    aux.Categoria.DescripcionCat = (string)datosArticulo.Lector["CategoriaDescripcion"];
                    aux.Descripcion = (string)datosArticulo.Lector["ArticuloDescripcion"];
                    aux.Marca.IdMarca = (int)datosArticulo.Lector["IdMarca"];
                    aux.Categoria.IdCat = (int)datosArticulo.Lector["IdCategoria"];
                    aux.Precio = (decimal)datosArticulo.Lector["Precio"];
                    aux.Imagen.Id = (int)datosArticulo.Lector["ImagenId"];
                    aux.Imagen.IdArticulo = (int)datosArticulo.Lector["ImagenIdArticulo"];
                    aux.Imagen.ImagenUrl = (string)datosArticulo.Lector["ImagenUrl"];


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

        public void agregar (Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
         
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) values ('" + nuevoArticulo.Codigo + "', '" + nuevoArticulo.Nombre + "','" + nuevoArticulo.Descripcion + "'," + nuevoArticulo.Precio + ", @IdMarca, @IdCategoria)");
                datos.setearParametro("@IdMarca", nuevoArticulo.Marca.IdMarca);
                datos.setearParametro("@Idcategoria", nuevoArticulo.Categoria.IdCat);
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
            Articulo aux = new Articulo();
            aux.Imagen = new Imagen();
            try
            {
                datos.abrirConexion();
                datos.setearConsulta("select Id From ARTICULOS A WHERE Codigo = '" + nuevoArticulo.Codigo + "'");
                datos.ejecutarLectura();
                
                if (datos.Lector.Read())
                {
                    aux.Imagen.IdArticulo = (int)datos.Lector["Id"];
                    //datos.ejecutarAccion();
                }              

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

            }

            try
            {
                datos.abrirConexion();
                datos.setearConsulta("insert into IMAGENES (IdArticulo, ImagenUrl) values (@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", aux.Imagen.IdArticulo );
                datos.setearParametro("@ImagenUrl", nuevoArticulo.Imagen.ImagenUrl);
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
                    aux.Imagen.ImagenUrl = (string)datos2.Lector["ImagenUrl"];

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
