using Jarvis.Interfaces;

namespace Jarvis.Logging
{
    public enum DebugLevel
    {
        HighLevel = 10,
        MidLevel = 20,
        LowLevel = 30
    }

    public class Logger
    {
        public static readonly Logger Instance = new Logger(new LogConsoleWriter());
        public bool EnableDebug;
        public DebugLevel DebugLevel = DebugLevel.HighLevel;

        private readonly ILogWriter _Writer;

        private Logger(ILogWriter Writer)
        {
            _Writer = Writer;
        }

        public void LogMsg(string Message)
        {
            _Writer.Write(LogType.Standard, Message);
        }

        public void LogError(string Error)
        {
            _Writer.Write(LogType.Error, Error);
        }

        public void Debug(string Message, DebugLevel Level = DebugLevel.HighLevel)
        {
            if (!EnableDebug) return;
            if ((int) Level > (int) DebugLevel) return;

            _Writer.Write(LogType.Debug, Message);
        }
    }
}
