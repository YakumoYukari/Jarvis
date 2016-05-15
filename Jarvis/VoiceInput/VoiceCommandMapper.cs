using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarvisRobot
{
    public class VoiceCommandMapper : ICommandMapper
    {
        private Dictionary<string, ICommand> Commands;
        public VoiceCommandMapper()
        {
            Commands = new Dictionary<string, ICommand>();
        }

        public bool Map(IVoiceCommand VoiceCommand, ICommand Command)
        {
            if (!Commands.ContainsKey(VoiceCommand.GetText()))
            {
                Commands.Add(VoiceCommand.GetText(), Command);
                return true;
            }
            return false;
        }

        public bool Unmap(IVoiceCommand VoiceCommand)
        {
            string text = VoiceCommand.GetText();
            if (Commands.ContainsKey(text))
            {
                Commands.Remove(text);
                return true;
            }
            return false;
        }
    }
}
