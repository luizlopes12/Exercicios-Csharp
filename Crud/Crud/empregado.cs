using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Crud
{
    class empregado : conexao
    {
        private string nome;
        private string sobrenome;
        private string cpf;

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getSobrenome()
        {
            return this.sobrenome;
        }
        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public void inserir()
        {
            string query = "INSERT INTO empregados(nomeEmpregado,sobreomeEmpregado,cpfEmpregado)VALUES('" +
                        this.nome + "' , '" + this.sobrenome + "' , '" + this.cpf + "')";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }

        }
















    }
}
