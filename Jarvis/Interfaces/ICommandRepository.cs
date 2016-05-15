using System.Collections.Generic;
using Jarvis.Commands;

namespace Jarvis.Interfaces
{
    public interface ICommandRepository
    {
        bool AddCommand(Command Command);
        bool HasCommand(string Identifier);
        Command GetCommand(string Identifier);
        List<Command> GetCommands();
        bool RemoveCommand(string Identifier);
        void Clear();
    }
}
