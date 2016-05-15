using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarvisRobot.Commands
{
    public class CodeCommand : ICommand
    {
        private Func<string[], string> Callback;
        public CodeCommand(Func<string[], string> Callback)
        {
            this.Callback = Callback;
        }

        public string Execute(params string[] args)
        {
            if (Callback != null)
                return Callback(args);
            return "";
        }

    }
}
