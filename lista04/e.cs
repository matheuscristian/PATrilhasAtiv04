using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tem_carteira;
        int idade;
        
        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());
        
        Console.Write("Digite seu nome? (Sim/Nao): ");
        tem_carteira = Console.ReadLine().Trim().ToLower();
        
        if (tem_carteira.Length > 3 && idade >= 18) {
            Console.WriteLine("Acesso permitido");
        } else {
            Console.WriteLine("Acesso negado");
        }
    }
}
