using Services.Contracts;

namespace Services.Concrete
{
    public class ConsoleLogger : ILoggerService
    {
        public void Info(string message)
        {
            Console.WriteLine("INFO: " + message);
        }

        public void Error(string message)
        {
            Console.WriteLine("ERROR: " + message);
        }

        public void Warn(string message)
        {
            Console.WriteLine("WARN: " + message);
        }
    }
}
