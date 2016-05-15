using System;
using Jarvis.Interfaces;

namespace Jarvis.Commands.Types
{
    public class CodeCommand : ICommand
    {
        private readonly Func<string[], string> _Callback;

        public CodeCommand(Func<string[], string> Callback)
        {
            _Callback = Callback;
        }

        public string Execute(params string[] Args)
        {
            return _Callback != null ? _Callback(Args) : "";
        }
    }
}
