using System;

namespace Lab5
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            throw new NotImplementedException();
        }

        public void LogError(Exception exception)
        {
            throw new NotImplementedException();
        }

        public void LogInfo(string message)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string message)
        {
            throw new NotImplementedException();
        }
    }
}
