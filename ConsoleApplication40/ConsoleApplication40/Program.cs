using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;
            Console.WriteLine("mês de nascimento:");
            mes = Console.ReadLine();
            switch(mes)
            {
                case "janeiro":
                case "fevereiro":
                case "março":
                    Console.WriteLine("1º trimestre:");
                    break;
                case "abril":
                case "maio":
                case "junho":
                    Console.WriteLine("2º trimestre:");
                    break;
                case "julho":
                case "agosto":
                case "setembro":
                    Console.WriteLine("3º trimestre:");
                    break;
                case "outubro":
                case "novembro":
                case "dezembro":
                    Console.WriteLine("1º trimestre:");
                    break;
                default:
                    Console.WriteLine("digite um mês válido");
                    break;

            }

            Console.ReadKey();






















        }
    }
}
