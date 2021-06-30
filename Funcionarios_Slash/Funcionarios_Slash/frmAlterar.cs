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
    public partial class frmAlterar : Form
    {
        funcionario f = new funcionario();
        public frmAlterar()
        {
            InitializeComponent();
        }

        private void btnConsultarRg_Click(object sender, EventArgs e)
        {
            funcionario f = new funcionario();
            string rg;
            try
            {
                rg = mskConsultarRg.Text;
                f.setRg(rg);
                dgvFuncionarioAlterar.DataSource = f.consultaPorRg();
            }
            catch 
            {

                MessageBox.Show("Não foi possivel encontrar o RG", "Tente novamente",MessageBoxButtons.OK);
            }




        }

        private void dgvFuncionarioAlterar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRg.Text = dgvFuncionarioAlterar.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvFuncionarioAlterar.CurrentRow.Cells[1].Value.ToString();
                txtDataAd.Text = dgvFuncionarioAlterar.CurrentRow.Cells[2].Value.ToString();
                txtSal.Text = dgvFuncionarioAlterar.CurrentRow.Cells[3].Value.ToString();

            }
            catch
            {

                MessageBox.Show("Atributo não encontrado");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome, data, sal, rg;
            nome = txtNome.Text;
            data = txtDataAd.Text;
            sal = txtSal.Text;
            rg = txtRg.Text;

            try
            {
                f.setNome(nome);
                f.setAd(data);
                f.setSal(sal);
                f.setRg(rg);
                f.alterar();
                MessageBox.Show("Dados Alterados");
            }
            catch 
            {

                MessageBox.Show("Não foi possivel alterar os dados");
            }







        }
    }
}
