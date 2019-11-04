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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadCli form = new cadCli();
            form.MdiParent = this;
            form.Show();
        }

        private void tipoDeMóveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadTipoMovel form = new cadTipoMovel();
            form.MdiParent = this;
            form.Show();
        }

        private void projetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadProj form = new cadProj();
            form.MdiParent = this;
            form.Show();
        }
    }
}
