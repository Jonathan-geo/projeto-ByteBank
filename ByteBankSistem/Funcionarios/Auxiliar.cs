using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankSistem.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Criando Auxiliar");
        }

        public override double GetBonificacao()
        {
            
            return Salario * 0.5;
        }
        public override void AumentarSalario()
        {
            //É o mesmo que 
            //Salario = Salario + (Salario * 0.15);
            //Aumento 15%
            Salario *= 1.15;
        }
    }
}
