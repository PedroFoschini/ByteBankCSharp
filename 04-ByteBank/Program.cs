using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo Bruno antes transferência: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo Gabriela antes transferência: " + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo Bruno após transferência: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo Gabriela após transferência: " + contaDaGabriela.saldo);

            Console.WriteLine(resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
