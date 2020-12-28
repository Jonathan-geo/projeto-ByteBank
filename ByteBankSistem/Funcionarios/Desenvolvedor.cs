using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankSistem.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando Desenvolvedor");
        }

        public override double GetBonificacao()
        {
            
            return Salario * 0.1;
        }
        public override void AumentarSalario()
        {
            //É o mesmo que 
            //Salario = Salario + (Salario * 0.15);
            //Aumento 15%
            Salario *= 0.15;
        }
    }
}
