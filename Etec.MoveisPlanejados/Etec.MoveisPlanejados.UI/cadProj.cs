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
    public partial class cadProj : Form
    {
        public cadProj()
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

        private bool ValidarCampoNum(string campoValidar, string nomeCampo)
        {
            try
            {
                int.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!", "Moveis Planejados");
                return false;
            }
        }

        private bool ValidarCampoFloat(string campoValidar, string nomeCampo)
        {
            try
            {
                float.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!", "Moveis Planejados");
                return false;
            }
        }

        private bool ValidarCampoData(string campoValidar, string nomeCampo)
        {
            try
            {
                DateTime.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!", "Moveis Planejados");
                return false;
            }
        }

        private bool ValidarCampoTel(string campoValidar, string nomeCampo)
        {
            int cont = 0;
            for (int i = 0; i < campoValidar.Length; i++)
            {
                if (campoValidar[i] == '1' || campoValidar[i] == '2' || campoValidar[i] == '3'
                    || campoValidar[i] == '4' || campoValidar[i] == '5' || campoValidar[i] == '6'
                    || campoValidar[i] == '7' || campoValidar[i] == '8' || campoValidar[i] == '9'
                    || campoValidar[i] == '(' || campoValidar[i] == ')' || campoValidar[i] == '-')
                {
                }
                else
                {
                    cont = 1;
                }
            }
            if (cont == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!", "Moveis Planejados");
                return false;
            }
        }

        private void cadProj_Load(object sender, EventArgs e)
        {
            try
            {
                DAO.Banco dao = new DAO.Banco();
                dgvProjetos.DataSource = dao.retornarProjeto();
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
            if (ValidarCampoString(txtIdMovel.Text, "ID (Tipo do Móvel)") == false)
            {
                txtIdMovel.Clear();
                txtIdMovel.Focus();
                return;
            }
            if (ValidarCampoNum(txtIdMovel.Text, "ID (Tipo do Móvel)") == false)
            {
                txtIdMovel.Clear();
                txtIdMovel.Focus();
                return;
            }
            if (ValidarCampoString(txtIdCli.Text, "ID (Cliente)") == false)
            {
                txtIdCli.Clear();
                txtIdCli.Focus();
                return;
            }
            if (ValidarCampoNum(txtIdCli.Text, "ID (Cliente)") == false)
            {
                txtIdCli.Clear();
                txtIdCli.Focus();
                return;
            }
            if (ValidarCampoString(txtPreco.Text, "Preço") == false)
            {
                txtPreco.Clear();
                txtPreco.Focus();
                return;
            }
            if (ValidarCampoFloat(txtPreco.Text, "Preço") == false)
            {
                txtPreco.Clear();
                txtPreco.Focus();
                return;
            }
            if (ValidarCampoString(txtDtEntrega.Text, "Data de Entrega") == false)
            {
                txtDtEntrega.Clear();
                txtDtEntrega.Focus();
                return;
            }
            if (ValidarCampoData(txtDtEntrega.Text, "Data de Entrega") == false)
            {
                txtDtEntrega.Clear();
                txtDtEntrega.Focus();
                return;
            }

            try
            {
                DAO.Banco dao = new DAO.Banco();
                dao.cadastrarProjeto(int.Parse(txtIdMovel.Text), int.Parse(txtIdCli.Text), txtNome.Text, txtDesc.Text, float.Parse(txtPreco.Text), DateTime.Now, DateTime.Parse(txtDtEntrega.Text));
                dgvProjetos.DataSource = dao.retornarProjeto();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível efetuar o cadastro! Erro: " + erro.Message, "Moveis Planejados");
            }
            txtIdMovel.Clear();
            txtIdCli.Clear();
            txtNome.Clear();
            txtDesc.Clear();
            txtPreco.Clear();
            txtDtEntrega.Clear();
        }
    }
}
