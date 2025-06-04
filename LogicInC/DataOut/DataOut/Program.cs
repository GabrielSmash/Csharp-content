using System;
using System.Globalization;

namespace DataOut {
    class Program {
        static void Main(string[] args) {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            /*Console.Write("Bom dia!\n");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            */

            Console.WriteLine("Usuario: {0}\nIdade: {1} anos\nSaldo: R${2:f2}", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e o saldo é {saldo:f2} reais");

            Console.WriteLine(nome + " tem " + idade + " anos e o saldo é " + saldo.ToString("f2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}