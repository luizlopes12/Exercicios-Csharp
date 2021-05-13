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
            cnpj = maskedTextBox1.Text;
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
    }
}
