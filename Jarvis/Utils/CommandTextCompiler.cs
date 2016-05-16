using System.Collections.Generic;
using System.Linq;
using Jarvis.Commands;

namespace Jarvis.Utils
{
    public static class SpokenCommandCompiler
    {
        public static List<List<string>> CompileText(List<Command> CommandList)
        {
            int MaxLength = CommandList.Max(command => command.SpokenCommand.Split(' ').Length);

            var Spine = new List<string>[MaxLength];

            for (int i = 0; i < CommandList.Count; i++)
            {
                Spine[i] = new List<string>(CommandList.Count);

                int I = i;
                foreach (string[] Tokens in CommandList.Select(cmd => cmd.SpokenCommand.Split(' ')).Where(Tokens => I < Tokens.Length))
                {
                    Spine[i].Add(Tokens[i]);
                    //Choices c = new Choices();
                }
            }

            return Spine.ToList();
        }
    }
}
