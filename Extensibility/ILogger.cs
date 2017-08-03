
using System;

namespace CSharpIntermediate.Extensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
        void LogInfo(string format, object data);
    }
}
