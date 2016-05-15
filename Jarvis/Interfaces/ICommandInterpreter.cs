using System.Speech.Recognition;

namespace Jarvis.Interfaces
{
    public interface ICommandInterpreter
    {
        Grammar GetGrammar();
        void Interpret(string Input);
    }
}
