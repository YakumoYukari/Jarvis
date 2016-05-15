using System.Linq;
using Jarvis.Commands.Types;
using Jarvis.Interfaces;
using Jarvis.Utils;

namespace Jarvis
{
    public static class CommandRegistration
    {
        public static void RegisterCommands(ICommandRepository Repository)
        {
            Repository.AddCommand(new CodeCommand("EchoCommand", "Echo *", s => s));
            Repository.AddCommand(new ExecuteProgramCommand("Notepad", "launch notepad",
                @"C:\Program Files (x86)\Notepad++\notepad++.exe"));
        }

    }
}
