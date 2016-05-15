using System.Speech.Recognition;

namespace Jarvis.Interfaces
{
    public interface ICommandInterpreter
    {
        Grammar GetGrammar();
        string Interpret(string Input);
    }
}
