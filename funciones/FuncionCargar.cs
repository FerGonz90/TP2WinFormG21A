using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace funciones
{
    public class FuncionCargar
    {
        public void CargarCbxMarcas(ComboBox comboBox)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> listaMarcas = marcaNegocio.listar();

            foreach (Marca marca in listaMarcas)
            {
                comboBox.Items.Add(marca.NombreMarca);
            }
        }
    }
}
