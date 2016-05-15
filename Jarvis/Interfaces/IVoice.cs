using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarvisRobot
{
    public interface IVoice
    {
        void Speak(string text);
        void Squelch(); //Shut them up
    }
}
