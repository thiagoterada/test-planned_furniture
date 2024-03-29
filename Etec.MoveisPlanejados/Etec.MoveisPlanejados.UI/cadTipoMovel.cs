﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private bool ValidarCampoString(string campoValidar, string nomeCampo)
        {
            if (campoValidar == "")
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!", "Moveis Planejados");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cadTipoMovel_Load(object sender, EventArgs e)
        {
            try
            {
                DAO.Banco dao = new DAO.Banco();
                dgvTipoMov.DataSource = dao.retornarTipoMovel();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível conectar com o servidor! Erro: " + erro.Message, "Moveis Planejados");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }

            try
            {
                DAO.Banco dao = new DAO.Banco();
                dao.cadastrarTipoMovel(txtNome.Text, txtDesc.Text);
                dgvTipoMov.DataSource = dao.retornarTipoMovel();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível efetuar o cadastro! Erro: " + erro.Message, "Moveis Planejados");
            }
            txtDesc.Clear();
            txtNome.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cont = dgvTipoMov.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvTipoMov.Rows[i].Cells.Count; a++)
                {
                    if (dgvTipoMov.Rows[i].Selected == true || dgvTipoMov.Rows[i].Cells[a].Selected == true)
                    {
                        txtNome.Text = dgvTipoMov.Rows[i].Cells[1].Value.ToString();
                        txtDesc.Text = dgvTipoMov.Rows[i].Cells[2].Value.ToString();
                    }

                }
            }
            if (Directory.Exists(@"C:\Cadastros") == false)
            {
                Directory.CreateDirectory(@"C:\Cadastros");
            }
            using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Cadastros\Moveis.txt", true))
            {
                arquivoTexto.WriteLine("-- Iniciando Log -- ");
                arquivoTexto.WriteLine("Usuário efetuou uma consulta de tipos de móveis!");
                arquivoTexto.WriteLine("-- Término Log --");
                arquivoTexto.WriteLine(" ");
            }
        }
    }
}
