using System.Speech.Synthesis;
using Jarvis.Grammars;
using Jarvis.Interfaces;
using Jarvis.VoiceInput;
using Jarvis.VoiceOutput;

namespace Jarvis
{
    public class JarvisBot : IRobot
    {
        public bool Running { get; private set; }

        public readonly IVoice Voice;
        public readonly VoiceListener Listener;

        public JarvisBot()
        {
            Voice = new SpeechFunction();
            Voice.GetSynthesizer().SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);

            IGrammarConstructor GrammarRules = new DictationGrammarConstructor();
            
            var OurVoiceCommands = new VoiceCommandRepository();
            CommandRegistration.RegisterCommands(OurVoiceCommands);

            var Interpreter = new VoiceCommandInterpreter(OurVoiceCommands, GrammarRules);
            Interpreter.InterpretCallback += Recognize;

            Listener = new VoiceListener(Interpreter);

            //Todo: fetch result strings from commands and speak them
        }

        public void Recognize(string CommandResult)
        {
            if (string.IsNullOrWhiteSpace(CommandResult)) return;

            Speak(CommandResult);
        }

        public void Speak(string Text)
        {
            Voice.Speak(Text);
        }

        public void StartListening()
        {
            Running = true;
            Listener.StartListening();
        }

        public void StopListening()
        {
            Running = false;
            Listener.StopListening();
        }

        public bool IsRunning()
        {
            return Running;
        }
    }
}
