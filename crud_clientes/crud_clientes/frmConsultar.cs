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
    public partial class frmConsultar : Form
    {
        cliente c = new cliente();
        public frmConsultar()
        {
            InitializeComponent();
        }

        private void frmConsultar_Load(object sender, EventArgs e)
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

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dgvConsultar.DataSource = c.consultar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void mskRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
