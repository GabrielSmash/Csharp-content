using System;

namespace EntryData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Bem vindo {nome}!");

            /*Console.Write("Digite tres palavras: ");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine($"Voce digitou:\n{x}\n{y}\n{z}");*/

            /*Console.Write("Digite tres palavras: ");
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine($"1º: {p1}\n2º: {p2}\n3º: {p3}");*/

            Console.WriteLine("Digite tres palavras: ");
            string[] palavras = Console.ReadLine().Split(' ');
            Console.WriteLine($"1º: {palavras[0]}\n2º: {palavras[1]}\n3º: {palavras[2]}");

            Console.Write("Digite um numero inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Voce digitou: " + n1);

            Console.WriteLine("Digite um caracter: ");
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine("Voce digitou: " + c);
        }
    }
}