using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace crud_clientes
{
    public partial class Form1 : Form
    {
        cliente cli = new cliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cliente cli = new cliente();
                string rg, nome, end, tel;
                rg = mskRg.Text;
                nome = txtNome.Text;
                end = txtEnd.Text;
                tel = mskTel.Text;
                cli.setRg(rg);
                cli.setNome(nome);
                cli.setEnd(end);
                cli.setTel(tel);

                cli.inserir();
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch 
            {

                MessageBox.Show("Não foi possivel cadastrar os dados");
            }









        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmConsultar cons = new frmConsultar();
            cons.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmExcluir ex = new frmExcluir();
            ex.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterar alt = new frmAlterar();
            alt.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
