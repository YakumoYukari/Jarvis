using System.Speech.Recognition;

namespace Jarvis.Interfaces
{
    public interface IGrammarConstructor
    {
        void SetRepository(ICommandRepository CommandRepository);
        Grammar ConstructGrammar();
    }
}
