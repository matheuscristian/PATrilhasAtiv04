using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string quer_comprar, tem_dinheiro;
        
        Console.Write("Você quer comprar um carro novo? (Sim/Nao): ");
        quer_comprar = Console.ReadLine().Trim().ToLower();
        
        Console.Write("Você tem dinheiro para isso? (Sim/Nao): ");
        tem_dinheiro = Console.ReadLine().Trim().ToLower();
        
        if (quer_comprar[0] == 's' && tem_dinheiro[0] == 's') {
            Console.WriteLine("Parabens, voce pode comprar um carro novo!");
        } else {
            Console.WriteLine("Não pode comprar um carro novo.");
        }
    }
}
