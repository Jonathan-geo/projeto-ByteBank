using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _06_ByteBank
{

    public class ContaCorrente
    {



        /*
         * Maneira antiga de fazer
         * 
        
        //Cria o Atributo Encapsulado
        private Cliente _titular;

        //Manipula o Atributo Get e Set
        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }

        *
        */

        // O mesmo código de cima / maneira nova de fazer
        public Cliente Titular {get;set;}
        public int Agencia { get; set; }
        public int Numero { get; set; }


        private double _saldo = 100;

        //Novo Modo de Get Set 
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




        /*
         * 
         * Atigo Modo de Get Set
         * 
        public double GetSaldo()
        {
            return this.saldo;
        }

        public void SetSaldo(double saldo)
        {

            if(saldo < 0)
            {
                return;
            }
            else
            {
                this.saldo = saldo;
            }

        }
        */


        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }


        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }


    }

}
