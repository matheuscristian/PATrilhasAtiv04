using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string quer_comprar, tem_dinheiro;
        
        Console.Write("Voce assina a Netflix? (Sim/Nao): ");
        quer_comprar = Console.ReadLine().Trim().ToLower();
        
        Console.Write("Voce ja assistiu Hajime No Ippo? (Sim/Nao): ");
        tem_dinheiro = Console.ReadLine().Trim().ToLower();
        
        if (quer_comprar[0] == 's' && tem_dinheiro[0] == 's') {
            Console.WriteLine("Otimo, agora pode assistir a nova temporada!");
        } else {
            Console.WriteLine("paia man");
        }
    }
}
