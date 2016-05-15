using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarvisRobot
{
    public class CommandRepository
    {
        private readonly Dictionary<string, ICommand> CommandList;

        public CommandRepository(Dictionary<string, ICommand> Commands)
        {
            CommandList = Commands;
        }

        public bool AddCommand(string UniqueName, ICommand Command)
        {
            if (!CommandList.ContainsKey(UniqueName))
            {
                CommandList.Add(UniqueName, Command);
                return true;
            }
            return false;
        }

        public bool HasCommand(string UniqueName)
        {
            return CommandList.ContainsKey(UniqueName);
        }

        public ICommand GetCommand(string UniqueName)
        {
            if (HasCommand(UniqueName)) return CommandList[UniqueName];
            return null;
        }

        public List<string> GetCommands()
        {
            return CommandList.Keys.ToList<string>();
        }
    }
}
