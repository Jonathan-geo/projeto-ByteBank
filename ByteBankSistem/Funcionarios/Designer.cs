using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankSistem.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando Designer");
        }

        public override double GetBonificacao()
        {
            
            return Salario * 0.17;
        }
        public override void AumentarSalario()
        {
            //É o mesmo que 
            //Salario = Salario + (Salario * 0.15);
            //Aumento 15%
            Salario *= 1.11;
        }
    }
}
