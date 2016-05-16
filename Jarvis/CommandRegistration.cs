using Jarvis.Commands.Types;
using Jarvis.Interfaces;

namespace Jarvis
{
    public static class CommandRegistration
    {
        public static void RegisterCommands(ICommandRepository Repository)
        {
            Repository.AddCommand(new CodeCommand("EchoCommand", "Jarvis Echo *", s => s.Substring(12)));
            Repository.AddCommand(new ExecuteProgramCommand("Notepad", "Jarvis launch notepad",
                @"C:\Program Files (x86)\Notepad++\notepad++.exe"));
        }

    }
}
