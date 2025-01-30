using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tem_carteira;
        
        Console.Write("Voce quer comprar um produto: ");
        tem_carteira = Console.ReadLine().Trim().ToLower();
        
        if (tem_carteira[0] == 's') {
            Console.WriteLine("Obrigado pela compra!");
        }
    }
}
