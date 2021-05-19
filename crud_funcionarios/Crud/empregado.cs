using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

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
        public DataTable consultar()
        {
            this.abrirConexao();
            string query = "select * from empregados;";
            MySqlCommand cmd =  new MySqlCommand(query, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);


            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);


            return dt;
            //mysqlcommand faz acesso e conecta na query no bd
            //mysqladapter faz a requisição da query no bd
            //datatable cria uma tabela com os dados
            //da.Fill filtra os dados consultados
        }
        public DataTable consultaPorCpf()
        {
            this.abrirConexao();
            string query = $"select * from empregados where cpfEmpregado = '{this.getCpf()}';";

            MySqlCommand cmd = new MySqlCommand(query, conectar);
            MySqlDataAdapter dta = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            this.fecharConexao();
            dta.Fill(dt);
            return dt;        
        }

        public void excluir()
        {
            string query = $"delete from empregados where cpfEmpregado = '{this.cpf}'; ";

            if(this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }



        }












    }
}
