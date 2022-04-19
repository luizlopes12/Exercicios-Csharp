using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "uepa";
            conta.agencia = 033;
            conta.numero = 111221;
            conta.saldo = 22.66;

            Console.WriteLine($"{conta.titular}{conta.agencia}{conta.numero}{conta.saldo}");
            Console.ReadLine();
        }
    }
}
