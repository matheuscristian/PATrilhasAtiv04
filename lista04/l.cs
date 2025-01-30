using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int tem_carteira;
        
        Console.Write("Digite um numero: ");
        tem_carteira = int.Parse(Console.ReadLine());
        
        if (tem_carteira != 0) {
            Console.WriteLine("O numero eh diferente de zero");
        } else {
            Console.WriteLine("husahushaushuhsuhsuahsuhaushauhsuah");
        }
    }
}
