using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace Funcionarios_Slash
{
    class Login : conexao
    {
        private string usuario;
        private string senha;

        public string getUser()
        {
            return this.usuario;
        }
        public void setUser(string usuario)
        {
            this.usuario = usuario;
        }

        public string getSenha()
        {
            return this.senha;
        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public void cadastrarLogin()
        {
            string query = $"insert into usuarios(usuario, senha) values ('{this.usuario}', '{this.senha}')";
            if(this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

        public int logar()
        {
            this.abrirConexao();
            string sql = $"select count(usuario) from usuarios where usuario = '{this.getUser()}' and senha = '{this.getSenha()}';";
            MySqlCommand cmd = new MySqlCommand(sql, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            Int32 resultado = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            int valor_login;
            valor_login = resultado;
            this.fecharConexao();
            return valor_login;
        }


    }
}
