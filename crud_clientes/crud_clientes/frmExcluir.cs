using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_clientes
{
    public partial class frmExcluir : Form
    {
        cliente c = new cliente();
        public frmExcluir()
        {
            InitializeComponent();
        }

        private void mskRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnConsultarPorRg_Click(object sender, EventArgs e)
        {
            try
            {
                string rg;
                rg = mskRg.Text;
                c.setRg(rg);
                dgvConsultar.DataSource = c.consultarPorRg();
            }
            catch
            {
                MessageBox.Show("Rg incorreto, não encontrado.");
            }
        }

        private void dgvConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string rg;
                rg = mskRg.Text;
                c.setRg(rg);
                c.excluir();
                MessageBox.Show("Dados excluidos com sucesso!");
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir os dados.");
            }



        }
    }
}
