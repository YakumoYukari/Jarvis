using System;
using System.Speech.Synthesis;
using Jarvis.Interfaces;

namespace Jarvis.VoiceOutput
{
    public class SpeechFunction : IVoice, IDisposable
    {
        private readonly SpeechSynthesizer _Synthesizer;

        public SpeechFunction()
        {
            _Synthesizer = new SpeechSynthesizer();
            _Synthesizer.SetOutputToDefaultAudioDevice();
        }

        public SpeechSynthesizer GetSynthesizer()
        {
            return _Synthesizer;
        }

        public void Speak(string Text)
        {
            _Synthesizer.SpeakAsync(Text);
            _Synthesizer.Resume();
        }

        public void Squelch()
        {
            _Synthesizer.SpeakAsyncCancelAll();
        }

        public void Dispose()
        {
            Squelch();
            _Synthesizer.Dispose();
        }
    }
}
