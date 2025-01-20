// Logs/Logger.cs
using System;
using System.IO;

namespace EmployeeManagementSystem.Logs
{
    public static class Logger
    {
        private static readonly string LogFile = "log.txt";

        public static void Log(string message)
        {
            var logMessage = $"{DateTime.Now}: {message}";
            File.AppendAllText(LogFile, logMessage + Environment.NewLine);
        }
    }
}
