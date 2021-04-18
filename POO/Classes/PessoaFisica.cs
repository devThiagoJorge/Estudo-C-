using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Classes
{
    class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public void DeclaraImposto()
        {
            Console.WriteLine("DEclarei");
        }
    }
}
