using log4net;
using log4net.Config;

namespace WinDropShot
{
    public static class LogController
    {
        /* Rolling log to file, using the log4net Framework
        * "The Apache Software Foundation log4net Logging Framework"
        *         
        * Use http://www.baremetalsoft.com/baretail/ to tail log on win systems.
        */

        private static readonly ILog Log = LogManager.GetLogger(typeof(LogController));

        static LogController()
        {
            XmlConfigurator.Configure();
        }

        public static void InfoMessage(string messageToLog)
        {
            Log.Info(messageToLog);
        }

        public static void DebugMessage(string messageToLog)
        {
            Log.Debug(messageToLog);
        }

        public static void WarnMessage(string messageToLog)
        {
            Log.Warn(messageToLog);
        }

        public static void ErrorMessage(string messageToLog)
        {
            Log.Error(messageToLog);
        }
    }
}