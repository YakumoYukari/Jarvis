using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace JarvisRobot.VoiceOutput
{
    public class SpeechFunction : IVoice, IDisposable
    {
        private readonly SpeechSynthesizer _syn;

        public SpeechFunction()
        {
            _syn = new SpeechSynthesizer();
            _syn.SetOutputToDefaultAudioDevice();
        }

        public void Speak(string text)
        {
            _syn.SpeakAsync(text);
        }

        public void Squelch()
        {
            _syn.SpeakAsyncCancelAll();
        }

        public void Dispose()
        {
            Squelch();
            _syn.Dispose();
        }
    }
}
