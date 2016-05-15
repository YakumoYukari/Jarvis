using Jarvis.Commands;

namespace Jarvis.Interfaces
{
    public interface ICommandInitializer
    {
        bool ReadCommands();
        ICommandRepository GetCommands();
    }
}
