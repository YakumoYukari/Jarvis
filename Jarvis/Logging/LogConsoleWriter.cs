using System;
using Jarvis.Interfaces;

namespace Jarvis.Logging
{
    public class LogConsoleWriter : ILogWriter
    {
        public void Write(LogType Type, string Message)
        {
            switch (Type)
            {
                case LogType.Standard:
                    WriteStandard(Message);
                    break;
                case LogType.Error:
                    WriteError(Message);
                    break;
                case LogType.Debug:
                    WriteDebug(Message);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Type), Type, null);
            }
        }

        private void WriteStandard(string Msg)
        {
            Console.WriteLine(Msg);
        }

        private void WriteError(string Err)
        {
            Console.Error.WriteLine(Err);
        }

        private void WriteDebug(string Msg)
        {
            Console.WriteLine("[Debug] " + Msg);
        }
    }
}
