using System.Speech.Recognition;
using Jarvis.Interfaces;

namespace Jarvis.Grammars
{
    public class DictationGrammarConstructor : IGrammarConstructor
    {
        public void SetRepository(ICommandRepository CommandRepository)
        {

        }
        public Grammar[] ConstructGrammars()
        {
            return new Grammar[] {new DictationGrammar()};
        }
    }
}
