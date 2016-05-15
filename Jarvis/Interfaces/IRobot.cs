using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis.Interfaces
{
    public interface IRobot
    {
        void Speak(string Text);
        void StartListening();
        void StopListening();
        bool IsRunning();
    }
}
