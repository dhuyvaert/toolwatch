using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ToolWatchLogger
{
    class LoggerLogToDataStore : IToolLogger
    {
        public Task<bool> Log(LogLevel level, string message) => throw new NotImplementedException();
        public Task<bool> Log(LogLevel level, Exception exception) => throw new NotImplementedException();
        public Task<bool> Log(LogLevel level, Exception exception, string message) => throw new NotImplementedException();
        public Task<bool> LogError(Exception exception) => throw new NotImplementedException();
        public Task<bool> LogError(Exception exception, string message) => throw new NotImplementedException();
        public Task<bool> LogInformation(string message) => throw new NotImplementedException();
        public Task<bool> LogWarning(string message) => throw new NotImplementedException();
    }
}
