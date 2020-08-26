using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ToolWatchLogger
{
    public class LoggerLogToFile : LogMessage, IToolLogger
    {
        public async Task<bool> Log(LogLevel level, string message) => await Save(BuildLogMessage(level, message));
        public async Task<bool> Log(LogLevel level, Exception exception) => await Save(BuildLogMessage(level, exception));
        public async Task<bool> Log(LogLevel level, Exception exception, string message) => await Save(BuildLogMessage(level, exception, message));
        public async Task<bool> LogError(Exception exception) => await Save(BuildLogMessage(LogLevel.Error, exception));
        public async Task<bool> LogError(Exception exception, string message) => await Save(BuildLogMessage(LogLevel.Error, exception, message));
        public async Task<bool> LogInformation(string message) => await Save(BuildLogMessage(LogLevel.Information, message));
        public async Task<bool> LogWarning(string message) => await Save(BuildLogMessage(LogLevel.Warning, message));
    }
}
