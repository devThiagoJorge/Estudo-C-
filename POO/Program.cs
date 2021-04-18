using POO.Classes;
using System;
using System.Collections.Generic;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa pessoa1 = new Pessoa();
            //pessoa1.Nome = "Thiago Jorge";
            //pessoa1.CPF = "12345678";
            //pessoa1.DataNascimento = new DateTime(2000, 03, 04);

            //Console.WriteLine($"A pessoa 1: {pessoa1.Nome}");

            //pessoa1.Pular();
            //pessoa1.Falar();

            //var pessoas = new List<Pessoa>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Informe o nome da pessoa");
            //    string nome = Console.ReadLine();
            //    var pessoa = new Pessoa
            //    {
            //        Nome = nome
            //    };

            //    pessoas.Add(pessoa);
            //}

            //foreach (var pessoa in pessoas)
            //{
            //    Console.WriteLine("Pessoas: " + pessoa.Nome);
            //}

            //var pessoaConstrutor = new Pessoa("Thiago");


            //Console.WriteLine($"PessoaContrutor {pessoaConstrutor.Nome} Criado em: {pessoaConstrutor.CriadoEm}");


            //SOBRECARGA
            //Pessoa pessoaSobrecarga = new Pessoa();

            //pessoaSobrecarga.Falar();
            //pessoaSobrecarga.Falar(2);


            // CLASSE ESTATICA -> PODE SER UTILIZADA SEM SER INSTANCIADA
            //Estatica.Escrever();


            // HERANÇA - HERDAMOS DA CLASSE PESSOA
            //PessoaFisica pessoaFisica = new PessoaFisica();

            //pessoaFisica.Nome = "Thiago";
            //pessoaFisica.DataNascimento = new DateTime(2000, 03, 04);

            //Console.WriteLine($"Pessoa Fisica: {pessoaFisica.Nome} {pessoaFisica.DataNascimento}");
            //pessoaFisica.Pular();
            //pessoaFisica.DeclaraImposto();

            //var pessoaJuridica = new PessoaJuridica();
            //pessoaJuridica.NomeFantasia = "Programas LTDA";

            //Console.WriteLine(pessoaJuridica.NomeFantasia + " Criado em " + pessoaJuridica.CriadoEm);



            // INTERFACE
            //var acoes = new Acoes();
            //acoes.Falar();
            //acoes.Ler();
        }
    }
}
