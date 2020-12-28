using ByteBankSistem.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankSistem.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando GerenteDeConta");
        }

        public override double GetBonificacao()
        {
            
            return Salario * 0.25;
        }
        public override void AumentarSalario()
        {
            //É o mesmo que 
            //Salario = Salario + (Salario * 0.15);
            //Aumento 15%
            Salario *= 1.05;
        }
    }
}
