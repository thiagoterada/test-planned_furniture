using System;
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
    }
}
