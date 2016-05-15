using Jarvis.Grammars;
using Jarvis.Interfaces;
using Jarvis.VoiceInput;
using Jarvis.VoiceOutput;

namespace Jarvis.Core
{
    public class Jarvis
    {
        private IVoice _Voice;
        private readonly VoiceListener _Listener;

        public Jarvis()
        {
            _Voice = new SpeechFunction();
            IGrammarConstructor GrammarRules = new DictationGrammarConstructor();
            
            var OurVoiceCommands = new VoiceCommandRepository();
            CommandRegistration.RegisterCommands(OurVoiceCommands);

            var Interpreter = new VoiceCommandInterpreter(OurVoiceCommands, GrammarRules);
            _Listener = new VoiceListener(Interpreter);

            //Todo: fetch result strings from commands and speak them
        }

        public void Run()
        {
            _Listener.StartListening();
        }

        public void Stop()
        {
            _Listener.StopListening();
        }
    }
}
