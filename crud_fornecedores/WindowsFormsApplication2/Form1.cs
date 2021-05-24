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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsulta con = new frmConsulta();
            con.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            fornecedor dor = new fornecedor();
            string cnpj, nome, telefone, email;
            cnpj = mskCnpj.Text;
            nome = txtNome.Text;
            telefone = mskTelefone.Text;
            email = txtEmail.Text;
            dor.setCNPJ(cnpj);
            dor.setNome(nome);
            dor.setTel(telefone);
            dor.setEmail(email);

            try
            {
                dor.inserir();
                MessageBox.Show("Dados adicionados, Show!");
            }
            catch 
            {

                MessageBox.Show("Deu merda :(");
            }



        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmExcluir ex = new frmExcluir();
            ex.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterar alt = new frmAlterar();
            alt.Show();
        }
    }
}
