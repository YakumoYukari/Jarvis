using System.Collections.Generic;
using Jarvis.Interfaces;

namespace Jarvis.VoiceInput
{
    public class VoiceCommandMapper : ICommandMapper
    {
        private readonly Dictionary<string, ICommand> _Commands;
        public VoiceCommandMapper()
        {
            _Commands = new Dictionary<string, ICommand>();
        }

        public bool Map(IVoiceCommand VoiceCommand, ICommand Command)
        {
            if (_Commands.ContainsKey(VoiceCommand.GetText())) return false;

            _Commands.Add(VoiceCommand.GetText(), Command);
            return true;
        }

        public bool Unmap(IVoiceCommand VoiceCommand)
        {
            string text = VoiceCommand.GetText();
            if (!_Commands.ContainsKey(text)) return false;

            _Commands.Remove(text);
            return true;
        }
    }
}
