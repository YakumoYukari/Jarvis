using System.Speech.Synthesis;
using Jarvis.Commands;
using Jarvis.Interfaces;
using Jarvis.Logging;
using Jarvis.VoiceInput;
using Jarvis.VoiceOutput;

namespace Jarvis
{
    public class JarvisBot : IRobot
    {
        private readonly VoiceCommandRepository _CommandRepository;
        private readonly IGrammarConstructor _GrammarRules;
        private bool _Loaded;

        public bool Running { get; private set; }

        public readonly IVoice Voice;
        private VoiceListener _Listener;

        public bool Enabled { get; }
        public bool Muted { get; }

        private JarvisBot()
        {
            Enabled = true;
            Muted = false;

            Voice = new SpeechFunction();
            Voice.GetSynthesizer().SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
        }

        public JarvisBot(VoiceCommandRepository Commands, IGrammarConstructor GrammarRules) : this()
        {
            _CommandRepository = Commands;
            _GrammarRules = GrammarRules;
        }

        public void AddCommand(Command NewCommand)
        {
            _CommandRepository.AddCommand(NewCommand);
        }

        public void Load()
        {
            var Interpreter = new VoiceCommandInterpreter(_CommandRepository, _GrammarRules);
            Interpreter.InterpretCallback += Recognize;

            _Listener = new VoiceListener(Interpreter);
            _Loaded = true;
        }

        public void Recognize(string CommandName, string CommandResult)
        {
            if (string.IsNullOrWhiteSpace(CommandResult)) return;

            ProcessResults(CommandName, CommandResult);
        }

        private void ProcessResults(string CommandName, string CommandResult)
        {
            if (!Enabled) return;

            Logger.Instance.LogMsg("Processing command: " + CommandName);
            Speak(CommandResult);
        }

        public void Speak(string Text)
        {
            if (Muted) return;
            Voice.Speak(Text);
        }

        public void StartListening()
        {
            if (!_Loaded) Load();

            Running = true;
            _Listener.StartListening();
        }

        public void StopListening()
        {
            Running = false;
            _Listener.StopListening();
        }

        public bool IsRunning()
        {
            return Running;
        }
    }
}
