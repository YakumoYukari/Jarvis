using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JarvisRobot.VoiceOutput;
using JarvisRobot.Commands;
using JarvisRobot.Utils;

namespace JarvisRobot
{
    public class Jarvis
    {
        private IVoice Voice;
        
        public Jarvis()
        {
            Voice = new SpeechFunction();
        }

        public void Run()
        {

        }

        public void Stop()
        {

        }
    }
}
