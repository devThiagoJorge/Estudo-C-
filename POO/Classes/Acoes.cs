using POO.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Classes
{
    public class Acoes : Verbos
    {
        public void Falar()
        {
            Console.WriteLine("Falei");
        }

        public void Ler()
        {
            Console.WriteLine("Acabei de ler");
        }
    }
}
