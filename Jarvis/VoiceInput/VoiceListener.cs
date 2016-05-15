using System;
using System.Speech.Recognition;
using Jarvis.Logging;

namespace Jarvis.VoiceInput
{
    public class VoiceListener : IDisposable
    {
        private SpeechRecognitionEngine _Recengine;
        private readonly VoiceCommandInterpreter _Interpreter;

        public bool IsListening { get; private set; }

        public VoiceListener(VoiceCommandInterpreter Interpreter)
        {
            _Interpreter = Interpreter;
            BuildGrammar();
        }

        private void BuildGrammar()
        {
            if (_Recengine == null) _Recengine = new SpeechRecognitionEngine();

            Grammar ConstructedGrammar = _Interpreter.GetGrammar();

            _Recengine.LoadGrammar(ConstructedGrammar);

            _Recengine.SpeechRecognized += OnSpeechRecognized;
            _Recengine.SetInputToDefaultAudioDevice();
        }

        private void OnSpeechRecognized(object Sender, SpeechRecognizedEventArgs e)
        {
            string FoundText = e.Result.Text;

            _Interpreter.Interpret(FoundText);
        }

        public void StartListening()
        {
            if (IsListening) return;

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
