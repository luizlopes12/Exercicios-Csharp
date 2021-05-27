using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace WindowsFormsApplication2
{
    class fornecedor : conexao
    {
        private string CNPJ;
        private string nome;
        private string tel;
        private string email;



        public string getCNPJ()
        {
            return this.CNPJ;
        }
        public void setCNPJ(string CNPJ)
        {
            this.CNPJ = CNPJ;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getTel()
        {
            return this.tel;
        }
        public void setTel(string tel)
        {
            this.tel = tel;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }

        public void inserir()
        {
            string query = "insert into fornecedores(CNPJ, Nome, Telefone, Email)VALUES('" +
                        this.CNPJ + "' , '" + this.nome + "' , '" + this.tel + "' , '" + this.email +"')";
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
            string query = "select * from fornecedores;";
            MySqlCommand cmd = new MySqlCommand(query, conectar);
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

        public DataTable consultarCnpj()
        {
            this.abrirConexao();
            string query = $"select * from fornecedores where CNPJ = '{this.CNPJ}';";
            MySqlCommand cmd = new MySqlCommand(query, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);


            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void excluir(){
            string query = $"delete from fornecedores where CNPJ = '{this.CNPJ}'";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
    }

}

            public void alterar(){
            string query = $"update fornecedores set nome = '{this.nome}', email = '{this.email}', telefone = '{this.tel}' where cnpj = '{this.CNPJ}';";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

    }
}
