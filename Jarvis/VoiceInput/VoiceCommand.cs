namespace Jarvis.VoiceInput
{
    public class VoiceCommand
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
    }
}
