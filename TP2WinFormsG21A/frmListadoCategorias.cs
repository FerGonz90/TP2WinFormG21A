﻿using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2WinFormsG21A
{
    public partial class frmListadoCategorias : Form
    {
        public frmListadoCategorias()
        {
            InitializeComponent();
        }

        private void frmListadoCategorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvListaCategorias.DataSource = negocio.listar();

        }
    }
}