using Estudo.Enums;
using System;
using System.Collections.Generic;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                TIPOS DE DADOS: INT, FLOAT, DOUBLE, VAR, STRING, CHAR, LISTAS, ENUM;
                CAST 
                ESTRUTURAS DE DECISÃO (IF, SWITCH)
                ESTRUTURAS DE REPETIÇÃO (WHILE, FOR, DO WHILE, FOREACH)
             */

            TIPOS DE DADOS

            int inteiro = 10;
            float quebrado = 10.4f;
            double quebradoDouble = 10.4;
            var a = "strings";
            var b = 10;
            var c = 10.4;

            int inteiro2 = 10;

            string texto = "Olá Matheus e Melissa Eu sou uma string!";

            char varChar = 's';
            string varString = "a";


            // LISTAS 

            List<int> listaInteiro = new List<int>();
            List<string> listaString = new List<string>();

            // ADICIONANDO ITENS NA LISTA
            listaInteiro.Add(10);
            listaInteiro.Add(20);
            listaString.Add("AAAAAAAAAAAA");

            var lista = new List<int>();
            lista.Add(10);

            // CASTS
            double quebradoCast = 10.4;
            int integer = (int)quebradoCast;
            string textArray = integer.ToString();
            Console.WriteLine(textArray);


            // ESTRTURA DE DECISÃO
            Console.WriteLine("Informe um dia da semana (numero)");
            int resposta = int.Parse(Console.ReadLine());

            if (DiasDaSemana.Segunda.Equals(resposta))
            {
                Console.WriteLine("Não entra");
            }

            if (resposta == (int)DiasDaSemana.Segunda)
            {
                Console.WriteLine("Entrei");
            }

            if (resposta == 2)
            {
                Console.WriteLine("Hoje é segunda-feira");
            }
            else if (resposta == 3)
            {
                Console.WriteLine("Hoje é terça-feira");
            }
            // Todas as condições tem que ser verdadeira (E)
            else if (resposta > 3 && resposta <= 7)
            {
                Console.WriteLine("Qualquer dia da semana");
            }
            // Basta uma condição ser verdadeira para entrar (OU)
            else if (resposta >= 30 || resposta > 50)
            {
                Console.WriteLine("Entreii aqui");
            }
            else
            {
                Console.WriteLine("Não existe");
            }

            Console.WriteLine("CASEEE");

            switch (resposta)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                default:
                    Console.WriteLine("Não Tem!");
                    break;
            }


            //WHILE = So roda quando for True


           int i = 0;

            while (i < 1)
            {
                Console.WriteLine($"Valor do {i}");
                i++;
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("For = " + j);
            }

            int k = 0;
            do
            {
                Console.WriteLine("Valor do while " + k);
                k++;
            } while (k < 1);


            var numerosInt = new List<int>();

            numerosInt.Add(11);
            numerosInt.Add(12);
            numerosInt.Add(13);
            numerosInt.Add(14);
            numerosInt.Add(15);
            numerosInt.Add(16);
            numerosInt.Add(17);
            numerosInt.Add(18);

            foreach (var numero in numerosInt)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
