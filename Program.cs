using System;
using newClass;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string message = MyClass.ReturnMessage();
        Console.WriteLine(message);
    }
}