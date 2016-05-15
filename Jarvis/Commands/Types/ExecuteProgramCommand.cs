using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace JarvisRobot.Commands.Implementations
{
    class ExecuteProgramCommand : ICommand
    {
        private readonly string _filepath;

        public ExecuteProgramCommand(string ProgramFilePath)
        {
            _filepath = ProgramFilePath;
        }

        public string Execute(params string[] args)
        {
            if (File.Exists(_filepath))
                System.Diagnostics.Process.Start(_filepath);
            return "";
        }
    }
}
