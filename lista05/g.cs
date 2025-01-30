using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num;
        Console.Write("Digite um numero: ");
        num = int.Parse(Console.ReadLine());
        
        string abs = num < 0 ? "negativo" : (num > 0 ? "positivo" : "zero");
        
        Console.WriteLine("O {0} eh {1}", num, abs);
    }
}
