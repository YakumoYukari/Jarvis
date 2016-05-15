using System;
using System.Speech.Recognition;
using Jarvis.Interfaces;

namespace Jarvis.VoiceInput
{
    public class VoiceListener : IDisposable
    {
        private SpeechRecognitionEngine _Recengine;
        private Choices _Choices;
        private GrammarBuilder _Grammarbuilder;
        private Grammar _Grammar;

        private bool _IsInitialized;
        private ICommandRepository _Commands;

        public bool IsListening { get; private set; }

        public VoiceListener(ICommandRepository CommandRepository)
        {
            _Commands = CommandRepository;
        }

        private void BuildGrammar()
        {
            if (_Recengine == null) _Recengine = new SpeechRecognitionEngine();

            _Choices = new Choices();

            _Grammarbuilder = new GrammarBuilder(_Choices);
            _Grammar = new Grammar(_Grammarbuilder);

            _Recengine.LoadGrammar(_Grammar);

            if (_IsInitialized) return;

            _Recengine.SpeechRecognized += OnSpeechRecognized;
            _Recengine.SetInputToDefaultAudioDevice();
            _IsInitialized = true;
        }

        private void OnSpeechRecognized(object Sender, SpeechRecognizedEventArgs E)
        {
            string foundText = E.Result.Text;

            //Todo: actually implement the command call
        }

        public void StartListening()
        {
            if (IsListening) return;

            BuildGrammar();

            _Recengine.RecognizeAsync(RecognizeMode.Multiple);
            IsListening = true;
        }

        public void StopListening()
        {
            if (!IsListening) return;

            _Recengine.RecognizeAsyncCancel();
            IsListening = false;
        }

        public void Dispose()
        {
            _Recengine.RecognizeAsyncCancel();
            _Recengine.Dispose();
        }
    }
}
