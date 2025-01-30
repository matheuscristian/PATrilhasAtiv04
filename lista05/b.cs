using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1, num2;
        Console.Write("Digite um numero: ");
        num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Digite outro numero: ");
        num2 = int.Parse(Console.ReadLine());
        
        string res = num1 > num2 ? num1 + " eh maior" : num2 + " eh maior";
        
        Console.WriteLine("O {0}", res);
    }
}
