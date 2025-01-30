using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tem_carteira;
        int idade;
        
        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());
        
        Console.Write("Você tem carteira? (Sim/Nao): ");
        tem_carteira = Console.ReadLine().Trim().ToLower();
        
        if (tem_carteira[0] == 's' && idade >= 18) {
            Console.WriteLine("Pode Dirigir");
        } else {
            Console.WriteLine("Não pode dirigir");
        }
    }
}
