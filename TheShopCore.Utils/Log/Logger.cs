using log4net;
using TheShopCore.Utils.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheShopCore.Utils.Log
{
    public static class Logger
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Logger));

        public static void Write(Enums.LogLevel logLevel, Exception exception)
        {
            var logMessage = Format(exception);
            switch (logLevel)
            {
                case Enums.LogLevel.Debug:
                    logger.Debug(logMessage);
                    break;
                case Enums.LogLevel.Error:
                    logger.Error(logMessage);
                    break;
                case Enums.LogLevel.Fatal:
                    logger.Fatal(logMessage);
                    break;
                case Enums.LogLevel.Info:
                    logger.Info(logMessage);
                    break;
                case Enums.LogLevel.Warn:
                    logger.Warn(logMessage);
                    break;
            }
        }

        public static void Write(Enums.LogLevel logLevel, string logMessage)
        {
            switch (logLevel)
            {
                case Enums.LogLevel.Debug:
                    logger.Debug(logMessage);
                    break;
                case Enums.LogLevel.Error:
                    logger.Error(logMessage);
                    break;
                case Enums.LogLevel.Fatal:
                    logger.Fatal(logMessage);
                    break;
                case Enums.LogLevel.Info:
                    logger.Info(logMessage);
                    break;
                case Enums.LogLevel.Warn:
                    logger.Warn(logMessage);
                    break;
            }
        }

        public static string Format(Exception exception)
        {
            return Environment.NewLine +
               "Source: " + exception.Source + Environment.NewLine +
               "Message: " + exception.Message + Environment.NewLine +
               "Stack trace: " + exception.StackTrace + Environment.NewLine +
               "Inner Exception: " + exception.InnerException;
        }
    }
}
