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
    class funcionario : conexao
    {
        private string rg;
        private string nome;
        private string dataAd;
        private string sal;

        public string getRg()
        {
            return this.rg;
        }
        public void setRg(string rg)
        {
            this.rg = rg;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getAd()
        {
            return this.dataAd;
        }
        public void setAd(string dataAd)
        {
            this.dataAd = dataAd;
        }

        public string getSal()
        {
            return this.sal;
        }
        public void setSal(string sal)
        {
            this.sal = sal;
        }
        public void inserir()
        {
            string query = "INSERT INTO funcionarios(rg,nome,dataAD,salario)VALUES('" +
                        this.rg + "' , '" + this.nome + "' , '" + this.dataAd + "','" + this.sal + "')";
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
            string query = "select rg as RG, nome as Nome, dataAd as Admissão, salario as Salário from funcionarios;";
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
        public DataTable consultaPorRg()
        {
            this.abrirConexao();
            string query = $"select * from funcionarios where rg = '{this.getRg()}';";

            MySqlCommand cmd = new MySqlCommand(query, conectar);
            MySqlDataAdapter dta = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            this.fecharConexao();
            dta.Fill(dt);
            return dt;
        }

        public void excluir()
        {
            string query = $"delete from funcionarios where rg = '{this.rg}'; ";

            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }



        }

        public void alterar()
        {
            string query = $"update funcionarios set nome = '{this.nome}', dataAd = '{this.dataAd}', salario = '{this.sal}' where rg = '{this.rg}';";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }










































    }
}
