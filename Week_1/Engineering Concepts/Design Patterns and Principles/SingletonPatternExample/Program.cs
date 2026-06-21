using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Logger instances
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            // Use the logger
            logger1.Log("First message");
            logger2.Log("Second message");

            // Verify both references point to the same object
            if (logger1 == logger2)
            {
                Console.WriteLine("Only one Logger instance exists.");
            }
            else
            {
                Console.WriteLine("Multiple Logger instances exist.");
            }
        }
    }
}