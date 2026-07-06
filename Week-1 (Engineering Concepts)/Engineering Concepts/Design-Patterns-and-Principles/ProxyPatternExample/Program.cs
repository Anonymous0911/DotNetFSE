using System;

class Program
{
    static void Main(string[] args)
    {
        Image image = new ProxyImage("Nature.jpg");

        Console.WriteLine("First Display:");
        image.Display();

        Console.WriteLine();

        Console.WriteLine("Second Display:");
        image.Display();
    }
}