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
        }
    }
}
