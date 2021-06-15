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
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            funcionario f = new funcionario();
            string rg, nome, data, sal;
            rg = mskRg.Text;
            nome = txtNome.Text;
            data = mskData.Text;
            sal = txtSal.Text;
            f.setRg(rg);
            f.setNome(nome);
            f.setAd(data);
            f.setSal(sal);

            try
            {
                f.inserir();
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
            catch 
            {

                MessageBox.Show("Não foi possivel cadastrar os dados");
            }






        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            funcionario f = new funcionario();
            mskRg.Text = "";
            txtNome.Text = "";
            mskData.Text = "";
            txtSal.Text = "";

            




        }
    }
}
