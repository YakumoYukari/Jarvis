using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarvisRobot
{
    public class VoiceCommand
    {
        private readonly string _command;
        public VoiceCommand(string Speech)
        {
            _command = Speech;
        }

        public string GetText()
        {
            return _command;
        }
    }
}
