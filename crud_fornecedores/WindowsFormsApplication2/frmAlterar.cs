using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmAlterar : Form
    {
        public frmAlterar()
        {
            InitializeComponent();
        }

        private void mskExcluirCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnConsultarCnpj_Click(object sender, EventArgs e)
        {
            fornecedor dor = new fornecedor();
            string cnpj;
            cnpj = mskConsultarCnpj.Text;
            dor.setCNPJ(cnpj);
            dgvAlterar.DataSource = dor.consultarCnpj();

        }

        private void dgvAlterar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCnpj.Text = dgvAlterar.CurrentRow.Cells[1].Value.ToString();
                txtNome.Text = dgvAlterar.CurrentRow.Cells[2].Value.ToString();
                txtTel.Text = dgvAlterar.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dgvAlterar.CurrentRow.Cells[4].Value.ToString();

            }
            catch
            {

                MessageBox.Show("Atributo não encontrado");
            }
        }

        private void frmAlterar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fornecedor dor = new fornecedor();
            string nome, tel, email, cnpj;
            nome = txtNome.Text;
            email = txtEmail.Text;
            tel = txtTel.Text;
            cnpj = txtCnpj.Text;
            dor.setCNPJ(cnpj);
            dor.setNome(nome);
            dor.setEmail(email);
            dor.setTel(tel);
            try
            {
                dor.alterar();
                MessageBox.Show("Dados alterados com sucesso");
            }
            catch
            {
                MessageBox.Show("Não foi possivel alterar os dados");

            }


        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
