using System.Collections.Generic;
using Jarvis.Commands;

namespace Jarvis.Interfaces
{
    public interface ICommandRepository
    {
        bool AddCommand(Command Command);
        void AddCommands(ICommandRepository Commands);
        bool HasCommand(string Identifier);
        Command GetCommand(string Identifier);
        List<Command> GetCommands();
        bool RemoveCommand(string Identifier);
        void Clear();
    }
}
