using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class frmAlterar : Form
    {
        empregado gado = new empregado();
        public frmAlterar()
        {
            InitializeComponent();
        }

        private void btnConsultarCpf_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf;
                cpf = mskConsultaCpf.Text;
                gado.setCpf(cpf);
                dgvEmpregadoAlterar.DataSource = gado.consultaPorCpf();


            }
            catch
            {
                MessageBox.Show("Não foi possivel consultar os dados.");
            }
        }

        private void dgvEmpregadoAlterar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNome.Text = dgvEmpregadoAlterar.CurrentRow.Cells["nomeEpregado"].Value.ToString();
                txtSobrenome.Text = dgvEmpregadoAlterar.CurrentRow.Cells["sobreomeEpregado"].Value.ToString();
                mskCpf.Text = dgvEmpregadoAlterar.CurrentRow.Cells["sobreomeEpregado"].Value.ToString();
            }
            catch 
            {
                MessageBox.Show("Atributo não localizado");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, sobrenome, cpf;
                nome = txtNome.Text;
                sobrenome = txtSobrenome.Text;
                cpf = mskCpf.Text;
                gado.setNome(nome);
                gado.setSobrenome(sobrenome);
                gado.alterar();
                MessageBox.Show("Dados alterados com sucesso!");
            }
            catch
            {

                MessageBox.Show("Erro ao alterar os dados.");
            }
        }
    }
}
