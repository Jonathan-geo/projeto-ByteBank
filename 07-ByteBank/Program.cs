using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {

        //CHAMADA MAIN
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch(Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }

            

            Console.WriteLine("Pressione a tecla enter para sair");
            Console.ReadLine();
        }




        private static void CarregarContas()
        {

            using(LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }



            //----------------------------------------------


            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

            //}
            //finally
            //{
            //    Console.WriteLine("Executando o Finally!");
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
                
            //}

        }




        //METODOS DEDICADOS

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(1234, 23456);
                ContaCorrente conta2 = new ContaCorrente(2345, 234);


                //conta1.Transferir(10000, conta2);
                conta1.Sacar(1000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("informações da INNER EXCEPTION (exceção interna): ");

            }
        }




    }
}
