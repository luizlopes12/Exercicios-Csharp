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










































    }
}
