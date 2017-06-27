using Narcissus.Logging.Abstract;
using Narcissus.Logging.Core;
using System;
using System.Threading.Tasks;

namespace Narcissus.Logging.Extention
{
    public static class ILogAsyncExtention
    {
        public static async Task LogAsync<TState>(this ILogger logger, LogLevel level, Exception exception, string message, TState state) where TState : class
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }
            ILogContext logContext = new LogContext(new WebAppContext(ServerEnvVariables.Instance));
            await logger.LogAsync<TState>(level, logContext, exception, message, state);
        }
        public static async Task LogAsync(this ILogger logger, LogLevel level, Exception exception, string message)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }
            await logger.LogAsync<object>(level, exception, message, null);
        }

        public static async Task LogAsync(this ILogger logger, LogLevel level, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(level, exception, string.Format(message, args));
        }

        public static async Task DebugAsync(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Debug, exception, message, args);
        }

        public static async Task DebugAsync(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Debug, null, message, args);
        }


        public static async Task TraceAsync(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Trace, exception, message, args);
        }


        public static async Task TraceAsync(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }


            await logger.LogAsync(LogLevel.Trace, null, message, args);
        }


        public static async Task InfoAsync(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Info, exception, message, args);
        }

        public static async Task InfoAsync(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Info, null, message, args);
        }


        public static async Task WarnAsync(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Warn, exception, message, args);
        }


        public static async Task WarnAsync(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Warn, null, message, args);
        }


        public static async Task ErrorAsync(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Error, exception, message, args);
        }


        public static async Task ErrorAsync(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Error, null, message, args);
        }
        public static async Task CriticalAsync(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Critical, exception, message, args);
        }


        public static async Task CriticalAsync(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Critical, null, message, args);
        }

        public static async Task FatalAsync(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Fatal, exception, message, args);
        }


        public static async Task FatalAsync(this ILogger logger, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            await logger.LogAsync(LogLevel.Fatal, null, message, args);
        }
    }
}
