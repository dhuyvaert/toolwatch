using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWatchLogger
{
    public class LogMessage : LogToFile
    {
        private string logDateTime = DateTime.UtcNow.ToString();
        public string BuildLogMessage(LogLevel level, string message) => $"{logDateTime} - [{level.ToString().ToUpper()}] - CUSTOM MESSAGE: {message}{Environment.NewLine}";
        public string BuildLogMessage(LogLevel level, Exception exception) => $"{logDateTime} - [{level.ToString().ToUpper()}] - {parseException(exception)}{Environment.NewLine}";
        public string BuildLogMessage(LogLevel level, Exception exception, string message) => $"{logDateTime} - [{level.ToString().ToUpper()}] - {parseException(exception)} - CUSTOM MESSAGE: {message}{Environment.NewLine}";
        private string parseException(Exception exception)
        {
            return $"EXCEPTION: {exception.InnerException?.ToString()} - EXCEPTION MESSAGE: {exception?.Message}";
        }
    }
}
