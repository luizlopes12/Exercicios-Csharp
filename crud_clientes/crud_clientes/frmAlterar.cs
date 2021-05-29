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
    public partial class frmAlterar : Form
    {
        cliente c = new cliente();
        public frmAlterar()
        {
            InitializeComponent();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente cli = new cliente();
                string rg, nome, end, tel;
                rg = mskRgConsultar.Text;
                nome = txtNome.Text;
                end = txtEnd.Text;
                tel = mskTel.Text;
                cli.setRg(rg);
                cli.setNome(nome);
                cli.setEnd(end);
                cli.setTel(tel);

                cli.alterar();
                MessageBox.Show("Dados alterados com sucesso!");
            }
            catch
            {

                MessageBox.Show("Não foi possivel alterar os dados");
            }

        }

        private void dgvConsultar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mskRgConsultar.Text = dgvConsultar.CurrentRow.Cells["rg"].Value.ToString();
                txtNome.Text = dgvConsultar.CurrentRow.Cells["nome"].Value.ToString();
                txtEnd.Text = dgvConsultar.CurrentRow.Cells["endereco"].Value.ToString();
                mskTel.Text = dgvConsultar.CurrentRow.Cells["telefone"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possivel localizar o item");
            }
        }
    }
}
