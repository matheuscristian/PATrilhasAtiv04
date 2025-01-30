using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tem_carteira;
        
        Console.Write("Voce que acucar ou leite no seu cafe?: ");
        tem_carteira = Console.ReadLine().Trim().ToLower();
        
        if (tem_carteira == "acucar" || tem_carteira == "leite") {
            Console.WriteLine("Cafe com adicional preparado!");
        }
    }
}
