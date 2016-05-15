using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using Jarvis.Commands;
using Jarvis.Interfaces;

namespace Jarvis.VoiceInput
{
    public class VoiceCommandInterpreter : ICommandInterpreter
    {
        private readonly VoiceCommandRepository _Repository;
        private readonly IGrammarConstructor _GrammarConstructor;

        public VoiceCommandInterpreter(VoiceCommandRepository Repository, IGrammarConstructor GrammarConstructor)
        {
            _Repository = Repository;
            _GrammarConstructor = GrammarConstructor;
            _GrammarConstructor.SetRepository(Repository);
        }

        public Grammar GetGrammar()
        {
            return _GrammarConstructor.ConstructGrammar();
        }

        public string Interpret(string Input)
        {
            var FoundCommand = _Repository.GetCommands();

            return "";
        }
    }
}
