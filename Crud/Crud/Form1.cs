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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //instanciar o objeto
            empregado gado = new empregado();
            //criar as variaveis
            string nome, sobre, cpf;
            nome = txtNome.Text;
            sobre = txtSobrenome.Text;
            cpf = mskCpf.Text;

            //tratamento de erros
            try
            {
                gado.setNome(nome);
                gado.setSobrenome(sobre);
                gado.setCpf(cpf);
                //chamando o metodo inserir
                gado.inserir();
                MessageBox.Show(cpf);
            }
            catch
            {
                MessageBox.Show("Erro ao inserir os dados."); 
            }








        }
    }
}
