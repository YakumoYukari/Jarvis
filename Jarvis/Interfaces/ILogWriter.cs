namespace Jarvis.Interfaces
{
    public enum LogType
    {
        Standard,
        Error,
        Debug
    }

    public interface ILogWriter
    {
        void Write(LogType Type, string Message);
    }
}
