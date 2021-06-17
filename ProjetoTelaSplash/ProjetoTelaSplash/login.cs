using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTelaSplash
{
    class login : conexao
    {
        private string user;
        private string senha;


        public string getUser()
        {
            return this.user;
        }

        public void setUser(string user)
        {
            this.user = user;
        }

        public string getSenha()
        {
            return this.senha;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public void cadastrar()
        {
            string query = $"insert into usuarios(usuario, senha)values('{user}','{senha}')";
            if(this.abrirConexao() == true)
            {

            }
        }
    }
}
