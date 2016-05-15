using System;
using System.Speech.Synthesis;
using Jarvis.Interfaces;

namespace Jarvis.VoiceOutput
{
    public class SpeechFunction : IVoice, IDisposable
    {
        private readonly SpeechSynthesizer _Syn;

        public SpeechFunction()
        {
            _Syn = new SpeechSynthesizer();
            _Syn.SetOutputToDefaultAudioDevice();
        }

        public void Speak(string Text)
        {
            _Syn.SpeakAsync(Text);
        }

        public void Squelch()
        {
            _Syn.SpeakAsyncCancelAll();
        }

        public void Dispose()
        {
            Squelch();
            _Syn.Dispose();
        }
    }
}
