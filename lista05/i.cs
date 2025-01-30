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
        
        string res = num1 % num2 == 0 ? "eh divisivel" : "nao eh divisivel";
        
        Console.WriteLine("O {0} {1} por {2}", num1, res, num2);
    }
}
