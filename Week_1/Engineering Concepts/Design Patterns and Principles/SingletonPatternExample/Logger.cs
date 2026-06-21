using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        // Private static instance
        private static Logger instance;

        // Private constructor
        private Logger()
        {
        }

        // Public static method to get the single instance
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        // Logging method
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}