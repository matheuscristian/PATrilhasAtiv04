using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<int> num = new List<int>();
        
        string res = num.Count > 0 ? "cheia" : "vazia";
        
        Console.WriteLine("a lista esta {0}", res);
    }
}
