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
    }
}
