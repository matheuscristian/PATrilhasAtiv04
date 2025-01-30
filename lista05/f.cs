using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num;
        Console.Write("Digite um numero: ");
        num = int.Parse(Console.ReadLine());
        
        int abs = num < 0 ? 0 - num : num;
        
        Console.WriteLine("O abs de {0} eh {1}", num, abs);
    }
}
