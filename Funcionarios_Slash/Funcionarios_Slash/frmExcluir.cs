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
    public partial class frmExcluir : Form
    {
        funcionario f = new funcionario();
        public frmExcluir()
        {
            InitializeComponent();
        }

        private void btnConsultarCpf_Click(object sender, EventArgs e)
        {
            try
            {
                
                string rg;
                rg = mskConsultaRg.Text;
                f.setRg(rg);
                dgvEmpregadoExcluir.DataSource = f.consultaPorRg();


            }
            catch
            {
                MessageBox.Show("Não foi possivel consultar os dados.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string rg;
                rg = mskConsultaRg.Text;
                f.setRg(rg);
                f.excluir();
                MessageBox.Show("Dados excluidos.");
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir os dados.");
            }
        }

        private void mskConsultaCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
