using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tem_carteira;
        
        Console.Write("Digite seu nome: ");
        tem_carteira = Console.ReadLine().Trim().ToLower();
        
        if (tem_carteira == "wilson" || tem_carteira == "gloria")
            Console.WriteLine("Ola, bem vindo de volta!");
        }
    }
}
