using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios_Slash
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrar f = new frmCadastrar();
            f.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar c = new frmConsultar();
            c.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExcluir ex = new frmExcluir();
            ex.Show();
        }
    }
}
