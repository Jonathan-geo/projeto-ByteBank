using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Cliente
    {
        private string _cpf;

        public string Nome { get; set; }
        
        public string Profissao { get; set; }

        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                //Logica de validação do CPF
                _cpf = value.ToUpper();
            }
        }
    }

}
