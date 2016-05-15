using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarvisRobot
{
    interface ICommandInitializer
    {
        bool ReadCommands();
        CommandRepository GetCommands();
    }
}
