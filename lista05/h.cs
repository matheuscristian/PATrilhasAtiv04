using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num;
        Console.Write("Digite um numero: ");
        
        string p = int.TryParse(Console.ReadLine(), out num) ? "o numero eh " + num : "error";
        
        
        
        
        Console.WriteLine(p);
    }
}
