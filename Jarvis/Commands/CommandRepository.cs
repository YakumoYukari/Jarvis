using System.Collections.Generic;
using System.Linq;
using Jarvis.Interfaces;

namespace Jarvis.Commands
{
    public class CommandRepository
    {
        private readonly Dictionary<string, ICommand> _CommandList;

        public CommandRepository(Dictionary<string, ICommand> Commands)
        {
            _CommandList = Commands;
        }

        public bool AddCommand(string UniqueName, ICommand Command)
        {
            if (_CommandList.ContainsKey(UniqueName)) return false;

            _CommandList.Add(UniqueName, Command);
            return true;
        }

        public bool HasCommand(string UniqueName)
        {
            return _CommandList.ContainsKey(UniqueName);
        }

        public ICommand GetCommand(string UniqueName)
        {
            return HasCommand(UniqueName) ? _CommandList[UniqueName] : null;
        }

        public List<string> GetCommands()
        {
            return _CommandList.Keys.ToList();
        }
    }
}
