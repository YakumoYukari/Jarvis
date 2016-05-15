using Jarvis.Interfaces;

namespace Jarvis.VoiceInput
{
    public class VoiceCommand : ICommand
    {
        private readonly string _Command;
        public VoiceCommand(string Speech)
        {
            _Command = Speech;
        }

        public string GetText()
        {
            return _Command;
        }

        public string Execute(params string[] args)
        {
            return "";
        }
    }
}
