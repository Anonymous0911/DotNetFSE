using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("Application Started");
        logger2.Log("Processing Request");

        if (ReferenceEquals(logger1, logger2))
        {
            Console.WriteLine("Only one Logger instance exists.");
        }
        else
        {
            Console.WriteLine("Multiple Logger instances exist.");
        }
    }
}