using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //Instanciando a Classe
            ContaCorrente contaBruno = new ContaCorrente();

            //Atribuindo valores 
            contaBruno.titular = "Bruno";
            contaBruno.saldo = 200;


            //Instanciando a Classe
            ContaCorrente contaGabriela = new ContaCorrente();

            //Atribuindo valores 
            contaGabriela.titular = "Gabriela";
            contaGabriela.saldo = 300;


            Console.WriteLine("Saldo antes de sacar 50");
            Console.WriteLine(contaBruno.titular);
            Console.WriteLine(contaBruno.saldo);

            //Utilizando o método Sacar 
            contaBruno.Sacar(50);
            Console.WriteLine("Saldo após sacar 50");
            Console.WriteLine(contaBruno.titular);
            Console.WriteLine(contaBruno.saldo);

            //Utilizando o método Depositar
            contaBruno.Depositar(500);
            Console.WriteLine("Saldo após Depositar 500");
            Console.WriteLine(contaBruno.titular);
            Console.WriteLine(contaBruno.saldo);


            Console.WriteLine("Saldo conta Gabriela");
            Console.WriteLine(contaGabriela.titular);
            Console.WriteLine(contaGabriela.saldo);



            contaBruno.Transferir(100, contaGabriela);


            Console.WriteLine("Saldo conta Gabriela após receber 100 do Bruno");
            Console.WriteLine(contaGabriela.titular);
            Console.WriteLine(contaGabriela.saldo);


            Console.WriteLine("Saldo Bruno após transferir 100 p Gabriela");
            Console.WriteLine(contaBruno.titular);
            Console.WriteLine(contaBruno.saldo);
            */

            //----------------------Novo CLiente

            //Criar o objeto
            Cliente marcos = new Cliente();
            marcos.nome = "Marcos";
            marcos.profissao = "Desenvolvedor";
            marcos.cpf = "123.234.567-20";


            ContaCorrente contaMarcos = new ContaCorrente();
            contaMarcos.titular = marcos;
            contaMarcos.numeroConta = 1234555;
            contaMarcos.numeroAgencia = 23;
            contaMarcos.saldo = 2000;


            Console.WriteLine("Dados Marcos");
            Console.WriteLine("Nome: " + contaMarcos.titular.nome);
            Console.WriteLine("Saldo: " + contaMarcos.saldo);




            Console.ReadLine();

        }
    }
}
