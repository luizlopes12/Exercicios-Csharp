using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    class fornecedor
    {
        private double CNPJ;
        private string nome;
        private double tel;
        private string email;



        public double getCNPJ()
        {
            return this.CNPJ;
        }
        public void setCNPJ(double CNPJ)
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
        public double getTel()
        {
            return this.tel;
        }
        public void setTel(double tel)
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
            string query = "insert into crud_fornecedores (CNPJ, Nome, Telefone, Email) values(
                $'{CNPJ}'
                
                
                "
        }


    }
}
