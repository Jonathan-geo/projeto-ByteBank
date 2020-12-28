using ByteBankSistem.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankSistem.Sistemas
{
    public interface IAutenticavel
    {
        //METODO
        bool Autenticar(string senha);

    }//end interface
}//end namespace
