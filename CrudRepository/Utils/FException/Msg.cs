using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NLog;

namespace CrudRepository.Utils.FException
{
    /// <summary>
    /// Classe permet de gérer les exceptions
    /// </summary>
    public static class Msg
    {
        /// <summary>
        /// Logger
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// Tracer les erreurs
        /// </summary>
        /// <param name="message">Message</param>
        public static void TraceError(string message)
        {
            if (logger.IsErrorEnabled) logger.Error(message);
        }
        /// <summary>
        /// Tracer les erreurs
        /// </summary>
        /// <param name="message">message</param>
        /// <param name="exception">Exception</param>
        public static void TraceError(string message, Exception exception)
        {
            if (logger.IsErrorEnabled) logger.Error(message, exception);
        }
        /// <summary>
        /// Tracer les erreurs
        /// </summary>
        /// <param name="message">Message</param>
        public static void TraceFatal(string message)
        {
            if (logger.IsFatalEnabled)
            {
                logger.Fatal(message);
                throw new Exception();
            }
        }
        /// <summary>
        /// Tracer les erreurs
        /// </summary>
        /// <param name="message">message</param>
        /// <param name="exception">Exception</param>
        public static void TraceFatal(string message, Exception exception)
        {
            if (logger.IsFatalEnabled)
            {
                logger.Fatal(message, exception);
                throw exception;
            }
        }
        /// <summary>
        /// Tracer en mode information
        /// </summary>
        /// <param name="message">Message</param>
        public static void TraceInfo(string message)
        {
            if (logger.IsInfoEnabled) logger.Info(message);
        }
        /// <summary>
        /// Tracer en mode debug
        /// </summary>
        /// <param name="message">Message</param>
        public static void TraceVerbose(string message)
        {
            if (logger.IsDebugEnabled) logger.Debug(message);
        }
    }
}