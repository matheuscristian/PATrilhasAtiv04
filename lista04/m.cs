using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tem_carteira;
        
        Console.Write("Voce nao eh um membro inativo do clube do bolinha?: ");
        tem_carteira = Console.ReadLine().Trim().ToLower();
        
        if (tem_carteira[0] == 'n') {
            Console.WriteLine("por favor, renove sua inscricao para continuar a usufruir dos beneficios ilimitados do clube do bolinha :)");
        }
    }
}
