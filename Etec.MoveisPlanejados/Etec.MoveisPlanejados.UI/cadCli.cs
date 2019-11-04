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
    public partial class cadCli : Form
    {
        public cadCli()
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

        private void cadCli_Load(object sender, EventArgs e)
        {
            try
            {
                DAO.Banco dao = new DAO.Banco();
                dgvClientes.DataSource = dao.retornarCliente();
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
            if (ValidarCampoString(txtCPF.Text, "CPF") == false)
            {
                txtCPF.Clear();
                txtCPF.Focus();
                return;
            }
            if (ValidarCampoString(txtRG.Text, "RG") == false)
            {
                txtRG.Clear();
                txtRG.Focus();
                return;
            }
            if (ValidarCampoString(cboSexo.Text, "Sexo") == false)
            {
                cboSexo.ResetText();
                return;
            }
            if (ValidarCampoString(txtTel.Text, "Telefone") == false)
            {
                txtTel.Clear();
                txtTel.Focus();
                return;
            }
            if (ValidarCampoTel(txtTel.Text, "Telefone") == false)
            {
                txtTel.Clear();
                txtTel.Focus();
                return;
            }
            if (ValidarCampoString(txtUF.Text, "UF") == false)
            {
                txtUF.Clear();
                txtUF.Focus();
                return;
            }
            if (ValidarCampoString(txtCid.Text, "Cidade") == false)
            {
                txtCid.Clear();
                txtCid.Focus();
                return;
            }
            if (ValidarCampoString(txtBairro.Text, "Bairro") == false)
            {
                txtBairro.Clear();
                txtBairro.Focus();
                return;
            }
            if (ValidarCampoString(txtLogra.Text, "Logradouro") == false)
            {
                txtLogra.Clear();
                txtLogra.Focus();
                return;
            }
            if (ValidarCampoString(txtNum.Text, "Número") == false)
            {
                txtNum.Clear();
                txtNum.Focus();
                return;
            }
            if (ValidarCampoNum(txtNum.Text, "Número") == false)
            {
                txtNum.Clear();
                txtNum.Focus();
                return;
            }

            try
            {
                DAO.Banco dao = new DAO.Banco();
                dao.cadastrarCliente(txtNome.Text, txtCPF.Text, txtRG.Text, cboSexo.Text, txtTel.Text, txtCel.Text, txtUF.Text, txtCid.Text, txtBairro.Text, txtLogra.Text, int.Parse(txtNum.Text), txtCep.Text, txtCompl.Text);
                dgvClientes.DataSource = dao.retornarCliente();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possível efetuar o cadastro! Erro: " + erro.Message, "Moveis Planejados");
            }
            if (Directory.Exists(@"C:\Cadastros") == false)
            {
                Directory.CreateDirectory(@"C:\Cadastros");
            }
            using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Cadastros\Alunos.txt", true))
            {
                arquivoTexto.WriteLine("-- Iniciando Log -- ");
                arquivoTexto.WriteLine("Usuário efetuou um cadastro de Cliente:");
                arquivoTexto.WriteLine("Nome do Cliente: " + txtNome.Text);
                arquivoTexto.WriteLine("Sexo: " + cboSexo.Text);
                arquivoTexto.WriteLine("CPF: " + txtCPF.Text);
                arquivoTexto.WriteLine("RG: " + txtCPF.Text);
                arquivoTexto.WriteLine("Telefone: " + txtTel.Text);
                arquivoTexto.WriteLine("Celular: " + txtCel.Text);
                arquivoTexto.WriteLine("Estado: " + txtUF.Text);
                arquivoTexto.WriteLine("Cidade: " + txtCid.Text);
                arquivoTexto.WriteLine("Bairro: " + txtBairro.Text);
                arquivoTexto.WriteLine("Logradouro: " + txtLogra.Text);
                arquivoTexto.WriteLine("Número: " + txtNum.Text);
                arquivoTexto.WriteLine("CEP: " + txtCep.Text);
                arquivoTexto.WriteLine("Complemento: " + txtCompl.Text);
                arquivoTexto.WriteLine("-- Término Log --");
                arquivoTexto.WriteLine(" ");
            }
            txtNome.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            cboSexo.ResetText();
            txtTel.Clear();
            txtCel.Clear();
            txtUF.Clear();
            txtCid.Clear();
            txtBairro.Clear();
            txtLogra.Clear();
            txtNum.Clear();
            txtCep.Clear();
            txtCompl.Clear();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cont = dgvClientes.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvClientes.Rows[i].Cells.Count; a++)
                {
                    if (dgvClientes.Rows[i].Selected == true || dgvClientes.Rows[i].Cells[a].Selected == true)
                    {
                        txtNome.Text = dgvClientes.Rows[i].Cells[1].Value.ToString();
                        txtCPF.Text = dgvClientes.Rows[i].Cells[2].Value.ToString(); 
                        txtRG.Text = dgvClientes.Rows[i].Cells[3].Value.ToString(); 
                        cboSexo.Text = dgvClientes.Rows[i].Cells[4].Value.ToString(); 
                        txtTel.Text = dgvClientes.Rows[i].Cells[5].Value.ToString(); 
                        txtCel.Text = dgvClientes.Rows[i].Cells[6].Value.ToString(); 
                        txtUF.Text = dgvClientes.Rows[i].Cells[7].Value.ToString(); 
                        txtCid.Text = dgvClientes.Rows[i].Cells[8].Value.ToString(); 
                        txtBairro.Text = dgvClientes.Rows[i].Cells[9].Value.ToString(); 
                        txtLogra.Text = dgvClientes.Rows[i].Cells[10].Value.ToString(); 
                        txtNum.Text = dgvClientes.Rows[i].Cells[11].Value.ToString(); 
                        txtCep.Text = dgvClientes.Rows[i].Cells[12].Value.ToString(); 
                        txtCompl.Text = dgvClientes.Rows[i].Cells[13].Value.ToString(); 
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
                arquivoTexto.WriteLine("Usuário efetuou uma consulta de clientes!");
                arquivoTexto.WriteLine("-- Término Log --");
                arquivoTexto.WriteLine(" ");
            }

        }
    }
}
