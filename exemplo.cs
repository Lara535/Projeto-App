using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Olá! Qual é o seu nome?");
        string nome = Console.ReadLine();

        Console.WriteLine("Quantos anos você tem?");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Prazer em te conhecer, " + nome + "!");
        Console.WriteLine("Você tem " + idade + " anos.");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}