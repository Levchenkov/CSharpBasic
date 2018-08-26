using System;

namespace Lab5
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
        void LogError(Exception exception);
    }
}
