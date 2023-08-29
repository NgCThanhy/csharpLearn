using System;
using newClass;
using Basic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string message = MyClass.ReturnMessage();
        Console.WriteLine(message);
        TryVar.PrintOut();
    }
}