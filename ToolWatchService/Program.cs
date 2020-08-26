using System;
using ToolWatchLogger;

namespace ToolWatchService
{
    class Program
    {
       
        static void Main(string[] args)
        {
            IToolLogger logger = new LoggerLogToFile();
            Console.WriteLine("ToolWatch Log Writer");
            Console.WriteLine("Write Information Log Record");
            logger.LogInformation("Informational log record");
            Console.WriteLine("Write Warning Log Record");
            logger.LogWarning("Warning log record");
            Console.WriteLine("Write Error Log Record");
            logger.LogError(new Exception("ToolWatch Exception"), "Error log record");
            Console.ReadLine();
        }
    }
}
