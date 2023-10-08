namespace Services.Contracts
{
    public interface ILoggerService
    {
        public void Info(string message);
        public void Error(string message);
        public void Warn(string message);
    }
}
