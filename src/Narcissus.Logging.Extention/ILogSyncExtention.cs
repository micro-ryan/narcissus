using Narcissus.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcissus.Logging.Extention
{
    public static class ILogSyncExtention
    {
        public static void Log<TState>(this ILogger logger, LogLevel type,  Exception ex, string message,  TState state) where TState : class
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }
            Task.Run(() => logger.LogAsync<TState>(type, ex, message, state));
        }

        public static void Log(this ILogger logger, LogLevel level, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            Task.Run(() => logger.LogAsync(level, exception, message, args));
        }
        public static void  Log(this ILogger logger, LogLevel level, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(level, null, message, args);
        }

        public static void Debug(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Debug, exception, message, args);
        }

        public static void Debug(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Debug, null, message, args);
        }


        public static void Trace(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Trace, exception, message, args);
        }


        public static void Trace(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Trace, null, message, args);
        }


        public static void Info(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Info, exception, message, args);
        }

        public static void Info(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Info, null, message, args);
        }


        public static void Warn(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Warn, exception, message, args);
        }


        public static void Warn(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Warn, null, message, args);
        }


        public static void Error(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Error, exception, message, args);
        }


        public static void Error(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Error, null, message, args);
        }
        public static void Critical(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Critical, exception, message, args);
        }


        public static void Critical(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Critical, null, message, args);
        }

        public static void Fatal(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Fatal, exception, message, args);
        }


        public static void Fatal(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            logger.Log(LogLevel.Fatal, null, message, args);
        }
    }
}
