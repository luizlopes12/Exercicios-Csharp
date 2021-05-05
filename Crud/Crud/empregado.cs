using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            nome = this.nome;
        }
        public string getSobrenome()
        {
            return this.sobrenome;
        }
        public void setSobrenome(string sobrenome)
        {
            sobrenome = this.sobrenome;
        }
        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string cpf)
        {
            cpf = this.cpf;
        }
















    }
}
