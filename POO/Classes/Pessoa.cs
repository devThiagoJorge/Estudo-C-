using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    // Não pode ser instanciada
    public abstract class Pessoa
    {
        public Pessoa()
        {
            CriadoEm = DateTime.Now;
        }

        public Pessoa(string nome)
        {
            Nome = nome;
            CriadoEm = DateTime.Now;
        }

        // ENCAPSULAMENTO
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime CriadoEm { get; private set; }

        // MODIFICADO DE ACESSO: PRIVATE
        private void Correr()
        {
            Console.WriteLine("Estou correndo");
        }

        public void Pular()
        {
            Console.WriteLine("Estou pulando");
            Correr();
        }

        //SOBRECARGA
        public void Falar()
        {
            Console.WriteLine("Estou falando");
        }

        public void Falar(int i)
        {
            Console.WriteLine("Falei " + i);
        }
    }
}
