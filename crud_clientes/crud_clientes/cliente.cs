using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace crud_clientes
{
    class cliente:conexao
    {
        private string rg;
        private string nome;
        private string end;
        private string tel;

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

        public string getEnd()
        {
            return this.end;
        }
        public void setEnd(string end)
        {
            this.end = end;
        }

        public string getTel()
        {
            return this.tel;
        }
        public void setTel(string tel)
        {
            this.tel = tel;
        }
        
        public void inserir()
        {
            string query = $"insert into clientes(rg, nome, endereco, telefone) values ('{this.rg}', '{this.nome}', '{this.end}', '{this.tel}');";


            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }





        }











    }
}
