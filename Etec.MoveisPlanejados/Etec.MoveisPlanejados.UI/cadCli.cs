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
    public partial class cadCli : Form
    {
        public cadCli()
        {
            InitializeComponent();
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

        }
            
    }
}
