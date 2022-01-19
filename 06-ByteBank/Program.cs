using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();
            cliente.nome = "Guilherme";
            cliente.cpf = "111.111.111-11";
            cliente.profissao = "Programador";

            conta.Titular = cliente;
            conta.Saldo = -10;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.nome);

            Console.ReadLine();
        }
    }
}
