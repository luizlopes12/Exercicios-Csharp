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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            string senha, usuario;
            senha = txtSenha.Text;
            usuario = txtUsuario.Text;
            try
            {
                l.setSenha(senha);
                l.setUser(usuario);
                l.cadastrarLogin();
                MessageBox.Show("Cadastrado com sucesso");
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar");
            }

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            string senha, usuario;
            senha = txtSenha.Text;
            usuario = txtUsuario.Text;
            try
            {
                l.setSenha(senha);
                l.setUser(usuario);

                int r = l.logar();

                if(r == 1)
                {
                    frmInicio ini = new frmInicio();
                    ini.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha inválidos", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch 
            {
                MessageBox.Show("Erro ao logar");
                
            }
        }
    }
}
