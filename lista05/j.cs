using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int? num = null;
        
        string res = num == null ? "eh null" : "nao eh null";
        Console.WriteLine("{0} {1}", num, res);
    }
}
