using System;

namespace InterfaceExample
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message); 
        }
    }
}
