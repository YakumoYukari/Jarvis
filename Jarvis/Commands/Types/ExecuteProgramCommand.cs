using System.IO;
using Jarvis.Interfaces;

namespace Jarvis.Commands.Types
{
    internal class ExecuteProgramCommand : ICommand
    {
        private readonly string _Filepath;

        public ExecuteProgramCommand(string ProgramFilePath)
        {
            _Filepath = ProgramFilePath;
        }

        public string Execute(params string[] Args)
        {
            if (File.Exists(_Filepath))
                System.Diagnostics.Process.Start(_Filepath);
            return "";
        }
    }
}
