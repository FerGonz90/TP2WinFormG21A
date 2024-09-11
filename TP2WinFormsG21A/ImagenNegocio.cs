using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2WinFormsG21A
{
    internal class ImagenNegocio
    {
        public List<Imagen> listar()
        {

            List<Imagen> listaImagenes = new List<Imagen>();
            SqlConnection conexionImagenes = new SqlConnection();
            SqlCommand comandoImagenes = new SqlCommand();
            SqlDataReader lectorImagenes;

            try
            {
                conexionImagenes.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true;";
                comandoImagenes.CommandType = System.Data.CommandType.Text;
                comandoImagenes.CommandText = "select Id, ImagenUrl from IMAGENES";
                comandoImagenes.Connection = conexionImagenes;

                conexionImagenes.Open();
                lectorImagenes = comandoImagenes.ExecuteReader();

                while (lectorImagenes.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)lectorImagenes["Id"];
                    aux._Imagen = (string)lectorImagenes["ImagenUrl"];


                    listaImagenes.Add(aux);
                }


                return listaImagenes;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

            finally
            {
                conexionImagenes.Close();
            }

        }
    }
}
