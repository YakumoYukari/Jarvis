using System.Collections.Generic;
using System.Linq;
using Jarvis.Interfaces;
using Jarvis.Commands;

namespace Jarvis.VoiceInput
{
    public class VoiceCommandRepository : ICommandRepository
    {
        private readonly HashSet<Command> _CommandList;

        public VoiceCommandRepository()
        {
            _CommandList = new HashSet<Command>();
        }

        public bool AddCommand(Command Command)
        {
            if (_CommandList.Contains(Command)) return false;

            _CommandList.Add(Command);
            return true;
        }

        public bool HasCommand(string UniqueName)
        {
            return _CommandList.Any(c => c.Name == UniqueName);
        }

        public Command GetCommand(string UniqueName)
        {
            return _CommandList.SingleOrDefault(c => c.Name == UniqueName);
        }

        public List<Command> GetCommands()
        {
            return _CommandList.ToList();
        }

        public bool RemoveCommand(string UniqueName)
        {
            return _CommandList.RemoveWhere(c => c.Name == UniqueName) > 0;
        }

        public void Clear()
        {
            _CommandList.Clear();
        }
    }
}
