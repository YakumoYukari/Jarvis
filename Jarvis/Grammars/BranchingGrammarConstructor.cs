using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using Jarvis.Commands;
using Jarvis.Interfaces;

namespace Jarvis.Grammars
{
    public class BranchingGrammarConstructor : IGrammarConstructor
    {
        private ICommandRepository _Repository;

        public void SetRepository(ICommandRepository CommandRepository)
        {
            _Repository = CommandRepository;
        }
        public Grammar[] ConstructGrammars()
        {
            var Commands = _Repository.GetCommands();
            var Builders = new List<GrammarBuilder>(Commands.Count);

            foreach (Command CurrentCommand in Commands)
            {
                var Tokens = CurrentCommand.SpokenCommand.Split(' ');
                var Builder = new GrammarBuilder();

                for(int j = 0; j < Tokens.Length; j++)
                {
                    bool MatchesWildcard = Tokens[j] == "*";

                    if (MatchesWildcard && j == Tokens.Length - 1)
                    {
                        Builder.AppendDictation();
                    }
                    else if (MatchesWildcard)
                    {
                        Builder.AppendWildcard();
                    }
                    else
                    {
                        Builder.Append(Tokens[j]);
                    }
                }

                Builders.Add(Builder);
            }

            return Builders.Select(b => new Grammar(b)).ToArray();
        }
    }
}
