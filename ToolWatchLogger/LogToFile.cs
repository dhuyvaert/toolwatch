using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ToolWatchLogger
{
    public class LogToFile
    {
        /// <summary>
        /// Writes a string value to the log text file.
        /// </summary>
        /// <param name="logRecord"></param>
        /// <returns></returns>
        public async Task<bool> Save(string logRecord)
        {
            // TODO- This path should be injected from app settings.
            var logFile = @$"{Environment.CurrentDirectory}\ToolWatchLog.txt";
            try
            {
                await File.AppendAllTextAsync(logFile, logRecord);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
