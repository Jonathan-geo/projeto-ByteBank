using ByteBankSistem.Funcionarios;
using ByteBankSistem.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankSistem
{
    class Program
    {
        static void Main(string[] args)
        {

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("234.567.233-34");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";


            GerenteDeConta camila = new GerenteDeConta("123.324.567-34");
            camila.Nome = "Camila";
            camila.Senha = "abc";


            Funcionario pedro = new Designer("097.567.345-67");
            pedro.Nome = "Pedro";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";


            sistemaInterno.Logar(parceiro, "123456");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "acv");

        }
    }
}
