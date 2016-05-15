using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Recognition;

namespace JarvisRobot
{
    public class VoiceListener : IDisposable
    {
        private SpeechRecognitionEngine _recengine = null;
        private Choices _choices = null;
        private GrammarBuilder _grammarbuilder = null;
        private Grammar _grammar = null;

        private bool IsUpdated = false;

        public bool IsInitialized { get; private set; }
        public bool IsListening { get; private set; }

        private ICommandRepository _commands;

        public VoiceListener(ICommandRepository CommandRepository)
        {
            _commands = CommandRepository;
        }

        private void BuildGrammar()
        {
            if (IsUpdated) return;

            if (_recengine == null) _recengine = new SpeechRecognitionEngine();

            _choices = new Choices();

            _grammarbuilder = new GrammarBuilder(_choices);
            _grammar = new Grammar(_grammarbuilder);

            _recengine.LoadGrammar(_grammar);

            if (!IsInitialized)
            {
                _recengine.SpeechRecognized += OnSpeechRecognized;
                _recengine.SetInputToDefaultAudioDevice();
                IsInitialized = true;
            }

            IsUpdated = true;
        }

        private void OnSpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string FoundText = e.Result.Text;
        }

        public void StartListening()
        {
            if (IsListening) return;

            BuildGrammar();

            _recengine.RecognizeAsync(RecognizeMode.Multiple);
            IsListening = true;
        }

        public void StopListening()
        {
            if (!IsListening) return;

            _recengine.RecognizeAsyncCancel();
            IsListening = false;
        }

        public void Dispose()
        {
            _recengine.RecognizeAsyncCancel();
            _recengine.Dispose();
        }
    }
}
