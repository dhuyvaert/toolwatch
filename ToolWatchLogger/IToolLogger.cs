using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ToolWatchLogger
{
    public interface IToolLogger
    {
        Task<bool> LogInformation(string message);
        Task<bool> LogWarning(string message);
        Task<bool> LogError(Exception exception);
        Task<bool> LogError(Exception exception, string message);
        Task<bool> Log(LogLevel level, string message);
        Task<bool> Log(LogLevel level, Exception exception);
        Task<bool> Log(LogLevel level, Exception exception, string message);
    }
}
