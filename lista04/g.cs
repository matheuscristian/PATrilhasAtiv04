using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int tem_carteira;
        
        Console.Write("Digite um numero: ");
        tem_carteira = int.Parse(Console.ReadLine());
        
        if (tem_carteira % 3 == 0 || tem_carteira % 5 == 0) {
            Console.WriteLine("Numero divisivel por 3 ou por 5");
        }
    }
}
