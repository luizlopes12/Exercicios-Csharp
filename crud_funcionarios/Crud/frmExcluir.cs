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
    public partial class frmExcluir : Form
    {
        empregado gado = new empregado();
        public frmExcluir()
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
                dgvEmpregadoExcluir.DataSource = gado.consultaPorCpf();


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
                string cpf;
                cpf = mskConsultaCpf.Text;
                gado.setCpf(cpf);
                gado.excluir();
                MessageBox.Show("Dados excluidos.");
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir os dados.");
            }






        }
    }
}
