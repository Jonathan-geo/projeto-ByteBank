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
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.numeroAgencia = 863;
            contaGabriela.numeroConta = 863146;
            contaGabriela.saldo = 100;

            Console.WriteLine(contaGabriela.titular);
            Console.WriteLine("Agência Conta: " + contaGabriela.numeroAgencia);
            Console.WriteLine("Número Conta: " + contaGabriela.numeroConta);
            Console.WriteLine("Saldo: " + contaGabriela.saldo);

            Console.ReadLine();

        }
    }
}
