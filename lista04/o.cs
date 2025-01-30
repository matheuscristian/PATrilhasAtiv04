using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tem_carteira;
        
        Console.Write("Voce nao deseja cancelar a operacao?: ");
        tem_carteira = Console.ReadLine().Trim().ToLower();
        
        if (tem_carteira[0] == 'n') {
            Console.WriteLine("por favor, confirme o cancelamento da operacao");
        }
    }
}
