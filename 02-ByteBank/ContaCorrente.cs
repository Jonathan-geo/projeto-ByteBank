using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Não é necessário chamar o namespace da classe Cliente pois compartilha o mesmo 
//namespace desta classe.
//using _02_ByteBank;

namespace _02_ByteBank
{

    public class ContaCorrente
    {
        //caso não chame o nemespace no using deve referenciar ele aqui.
        //public _02_ByteBank.Cliente titular;

        public Cliente titular;
        public int numeroAgencia;
        public int numeroConta;
        public double saldo = 100;



        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }


        public void Depositar(double valor)
        {
            this.saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }


    }

}
