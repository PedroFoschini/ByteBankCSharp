using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idade2 = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idade2));


            Console.ReadLine();

        }
    }
}
