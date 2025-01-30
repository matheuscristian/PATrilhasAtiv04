using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tem_carteira;
        int idade;
        
        Console.Write("Você tem ensino superior? (Sim/Nao): ");
        tem_carteira = Console.ReadLine().Trim().ToLower();
        
        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());
        
        if (tem_carteira[0] == 's' && idade > 21) {
            Console.WriteLine("Parabens, voce esta qualificado para a vaga");
        } else {
            Console.WriteLine(":(");
        }
    }
}
