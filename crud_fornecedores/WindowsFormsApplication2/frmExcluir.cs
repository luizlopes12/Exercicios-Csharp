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
    public partial class frmExcluir : Form
    {
        public frmExcluir()
        {
            InitializeComponent();
        }

        private void btnConsultarCnpj_Click(object sender, EventArgs e)
        {
            fornecedor dor = new fornecedor();
            string cnpj;
            cnpj = mskExcluirCnpj.Text;
            dor.setCNPJ(cnpj);
            dgvExcluir.DataSource = dor.consultarCnpj();





        }

        private void btnExcluirCnpj_Click(object sender, EventArgs e)
        {
            fornecedor dor = new fornecedor();
            string cnpj;
            cnpj = mskExcluirCnpj.Text;
            dor.setCNPJ(cnpj);

            try
            {
                dor.excluir();
                MessageBox.Show("Dados excluidos com sucesso.");
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir os dados.");

            }







        }
    }
}
