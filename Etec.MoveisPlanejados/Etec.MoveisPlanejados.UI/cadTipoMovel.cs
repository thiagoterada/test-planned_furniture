﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etec.MoveisPlanejados.UI
{
    public partial class cadTipoMovel : Form
    {
        public cadTipoMovel()
        {
            InitializeComponent();
        }

        private void cadTipoMovel_Load(object sender, EventArgs e)
        {
            DAO.Banco dao = new DAO.Banco();
            dgvTipoMov.DataSource = dao.retornarTipoMovel();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DAO.Banco dao = new DAO.Banco();
            dao.cadastrarTipoMovel(txtNome.Text, txtDesc.Text);
            dgvTipoMov.DataSource = dao.retornarTipoMovel();
        }
    }
}