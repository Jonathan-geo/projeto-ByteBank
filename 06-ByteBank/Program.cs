using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Antigo Modo de Get e Set
            ContaCorrente conta = new ContaCorrente();

            Cliente judas = new Cliente();
            judas.nome = "Judas";


            conta.titular = judas;

            conta.SetSaldo(234);

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.GetSaldo());

            */



            //Novo modo de Get e Set

            Cliente marcos = new Cliente();
            marcos.Nome = "Marcos";
            marcos.Profissao = "Desenvolvedor";
            marcos.Cpf = "mg123.234.567-20";



            ContaCorrente conta = new ContaCorrente();

            //conta.Saldo = -10;
            conta.Saldo = 250;

            conta.Titular = marcos;



            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Titular.Cpf);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
