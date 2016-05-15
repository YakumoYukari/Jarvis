using System.Collections.Generic;
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
        public Grammar ConstructGrammar()
        {
            var Builder = new GrammarBuilder();

            List<Command> Commands = _Repository.GetCommands();

            foreach (Command Entry in Commands)
            {
                //Todo: Figure out fastest way to do this
            }

            return new Grammar(Builder);
        }
    }
}
