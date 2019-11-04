using System;
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
            //try
            //{
                DAO.Banco dao = new DAO.Banco();
                dgvProjetos.DataSource = dao.retornarProjeto();
                dgvClientes.DataSource = dao.retornarCliente();
                dgvTipoMov.DataSource = dao.retornarTipoMovel();
                int cont = dgvClientes.RowCount - 1;
                int cont1 = dgvTipoMov.RowCount - 1;
                for (int i = 0; i < cont; i++)
                {
                        listBox1.Items.Add(dgvClientes.Rows[i].Cells[0].Value.ToString() + " - " + dgvClientes.Rows[i].Cells[1].Value.ToString());

                }
                for (int i = 0; i < cont1; i++)
                {
                       listBox2.Items.Add(dgvTipoMov.Rows[i].Cells[0].Value.ToString() +" - "+ dgvTipoMov.Rows[i].Cells[1].Value.ToString());

                }
            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show("Não foi possível conectar com o servidor! Erro: " + erro.Message, "Moveis Planejados");
            //}
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cont = dgvProjetos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvProjetos.Rows[i].Cells.Count; a++)
                {
                    if (dgvProjetos.Rows[i].Selected == true || dgvProjetos.Rows[i].Cells[a].Selected == true)
                    {
                        txtNome.Text = dgvProjetos.Rows[i].Cells[3].Value.ToString();
                        txtIdMovel.Text = dgvProjetos.Rows[i].Cells[1].Value.ToString();
                        txtIdCli.Text = dgvProjetos.Rows[i].Cells[2].Value.ToString();
                        txtPreco.Text = dgvProjetos.Rows[i].Cells[5].Value.ToString();
                        txtDesc.Text = dgvProjetos.Rows[i].Cells[4].Value.ToString();
                        txtDtEntrega.Text = dgvProjetos.Rows[i].Cells[7].Value.ToString();
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
                arquivoTexto.WriteLine("Usuário efetuou uma consulta de projetos!");
                arquivoTexto.WriteLine("-- Término Log --");
                arquivoTexto.WriteLine(" ");
            }
        }
    }
}
