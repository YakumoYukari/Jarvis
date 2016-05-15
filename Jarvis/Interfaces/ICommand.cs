using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarvisRobot
{
    public interface ICommand
    {
        string Execute(params string[] args);
    }
}
