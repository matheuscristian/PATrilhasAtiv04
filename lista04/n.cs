using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tem_carteira;
        
        Console.Write("digite uma palavra: ");
        tem_carteira = Console.ReadLine().Trim().ToLower();
        
        if (tem_carteira.Length > 0) {
            Console.WriteLine("a palavra nao eh vazia");
        }
    }
}
