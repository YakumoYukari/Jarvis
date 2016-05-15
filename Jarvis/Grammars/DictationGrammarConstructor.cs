using System.Speech.Recognition;
using Jarvis.Interfaces;

namespace Jarvis.Grammars
{
    public class DictationGrammarConstructor : IGrammarConstructor
    {
        private ICommandRepository _Repository;

        public void SetRepository(ICommandRepository CommandRepository)
        {
            _Repository = CommandRepository;
        }
        public Grammar ConstructGrammar()
        {
            return new DictationGrammar();
        }
    }
}
