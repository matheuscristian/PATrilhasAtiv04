using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string num;
        Console.Write("Digite um texto: ");
        num = Console.ReadLine();
        
        string res = num.Length > 0 ? "cheia" : "vazia";
        
        Console.WriteLine("a string esta {0}", res);
    }
}
