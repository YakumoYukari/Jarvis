using Jarvis.Commands;

namespace Jarvis.Interfaces
{
    interface ICommandInitializer
    {
        bool ReadCommands();
        CommandRepository GetCommands();
    }
}
