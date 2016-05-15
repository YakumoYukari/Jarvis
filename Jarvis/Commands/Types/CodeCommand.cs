using System;
using Jarvis.Interfaces;

namespace Jarvis.Commands.Types
{
    public class CodeCommand : Command
    {
        private readonly Func<string[], string> _Callback;

        public CodeCommand(string Name, string SpokenCommand, Func<string[], string> Callback) : base(Name, SpokenCommand)
        {
            _Callback = Callback;
        }

        public override string Execute(params string[] Args)
        {
            return _Callback != null ? _Callback(Args) : "";
        }
    }
}
