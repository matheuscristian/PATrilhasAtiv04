using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        bool verdadeiro = true;
        
        string res = verdadeiro ? "true" : "false";
        
        Console.WriteLine("verdadeiro eh {0}", res);
    }
}
