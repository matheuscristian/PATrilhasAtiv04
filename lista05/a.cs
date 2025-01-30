using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num;
        Console.Write("Digite um numero: ");
        num = int.Parse(Console.ReadLine());
        
        string res = num % 2 == 0 ? "eh par" : "eh impar";
        
        Console.WriteLine("O {0} {1}", num, res);
    }
}
