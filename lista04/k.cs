using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tem_carteira;
        
        Console.Write("Voce eh um robo?: ");
        tem_carteira = Console.ReadLine().Trim().ToLower();
        
        if (tem_carteira[0] == 'n') {
            Console.WriteLine("por favor, prove que voce eh um robo :)");
        }
    }
}
