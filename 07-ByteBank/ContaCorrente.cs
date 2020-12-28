using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBankExceptions
{

    public class ContaCorrente
    {


        //----------------------------------ATRIBUTOS
        public Cliente Titular {get;set;}
        public static int TotalDeContasCriadas { get; private set; }
        private double _saldo = 100;
        public static double TaxaOperacao {get; private set;}
        public int Numero {get;}
        public int Agencia {get;}

        public int ContadorSaquesNaoPermitidos { get; private set; }

        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        //--------------------------------CONSTRUTOR
        public ContaCorrente(int agencia, int numero)
        {

            if (agencia <= 0)
            {

                ArgumentException excecao = new ArgumentException("A agencia deve ser maior que zero(0).", nameof(agencia));
                throw excecao;
                
            }

            if (numero <= 0)
            {

                ArgumentException excecao = new ArgumentException("O numero da conta deve ser maior que zero(0).", nameof(numero));
                throw excecao;
                
            }



            Agencia = agencia;
            Numero = numero;
            ContaCorrente.TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

            

        }



        




        //----------------------------------METODOS
          

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }
        //end Saldo



 



        //------------------------------------METODOS AUXILIARES
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (this._saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            else
            {
                this._saldo -= valor;

            }
        }
        //end Sacar



        public void Depositar(double valor)
        {
            this._saldo += valor;
        }
        //end Depositar


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferencia.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }


            contaDestino.Depositar(valor);

        }
        //end Transferir









    }//end class
}//end namespace
