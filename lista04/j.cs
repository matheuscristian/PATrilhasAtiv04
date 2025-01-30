using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int tem_carteira;
        
        Console.Write("Digite um numero: ");
        tem_carteira = int.Parse(Console.ReadLine());
        
        if (tem_carteira > 10 || tem_carteira < 0) {
            Console.WriteLine("Numero invalido");
        } else {
            Console.WriteLine("Numero valido");
        }
    }
}
