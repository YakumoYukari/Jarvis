using Jarvis.Interfaces;
using Jarvis.VoiceOutput;

namespace Jarvis.Core
{
    public class Jarvis
    {
        private IVoice _Voice;
        
        public Jarvis()
        {
            _Voice = new SpeechFunction();
        }

        public void Run()
        {

        }

        public void Stop()
        {

        }
    }
}
