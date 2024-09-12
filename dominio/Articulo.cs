﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public int Categoria { get; set; }
        //public string imagenArticulo { get; set; }
        public decimal Precio { get; set; }

        public Imagen Imagen { get; set; }


    }
}
