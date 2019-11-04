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
            DAO.Banco dao = new DAO.Banco();
            dgvProjetos.DataSource = dao.retornarProjeto();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DAO.Banco dao = new DAO.Banco();
            dao.cadastrarProjeto(int.Parse(txtIdMovel.Text), int.Parse(txtIdCli.Text), txtNome.Text, txtDesc.Text, float.Parse(txtPreco.Text), DateTime.Now, DateTime.Parse(txtDtEntrega.Text));
        }
    }
}
