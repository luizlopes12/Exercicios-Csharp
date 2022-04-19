using ByteBank.Funcionarios;
using System;

namespace ByteBank
{

    class Program
    {
        static void Main (string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario carlos = new Funcionario();
            Diretor roberta = new Diretor();
            roberta.Nome = "carlos";
            roberta.CPF = "595.182.129.99";
            roberta.Salario = 5000;
            gerenciador.Registrar(roberta);
            carlos.Nome = "carlos";
            carlos.CPF = "595.182.129.99";
            carlos.Salario = 2000;
            gerenciador.Registrar(carlos);

            carlos.getBonificacao();
            roberta.getBonificacao();

            Console.WriteLine($"Total de bonificações: {gerenciador.getTotalBonificacao()}");
        }

    }
}
