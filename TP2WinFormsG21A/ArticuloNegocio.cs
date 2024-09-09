using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TP2WinFormsG21A
{
    internal class ArticuloNegocio
    {
        public List<Articulo> listar() {

            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio From ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codigoArticulo = (int)lector["Id"];
                    aux.nombreArticulo = (string)lector["Nombre"];
                    aux.descripcionArticulo = (string)lector["Descripcion"];
                    aux.marcaArticulo = (int)lector["IdMarca"];
                    aux.categoriaArticulo = (int)lector["IdCategoria"];
                    //aux.precioArticulo = (float)lector["Precio"];

                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

            finally
            {
                conexion.Close();
            }
        
        }
        
    }
}
