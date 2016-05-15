using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarvisRobot
{
    public interface ICommandMapper
    {
        bool Map(IVoiceCommand VoiceCommand, ICommand Command);
        bool Unmap(IVoiceCommand VoiceCommand);
    }
}
