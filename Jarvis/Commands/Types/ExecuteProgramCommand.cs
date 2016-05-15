using System.IO;

namespace Jarvis.Commands.Types
{
    internal class ExecuteProgramCommand : Command
    {
        private readonly string _Filepath;

        public ExecuteProgramCommand(string Name, string SpokenCommand, string ProgramFilePath) : base(Name, SpokenCommand)
        {
            _Filepath = ProgramFilePath;
        }

        public override string Execute(string Args)
        {
            if (File.Exists(_Filepath))
                System.Diagnostics.Process.Start(_Filepath);
            return "";
        }
    }
}
