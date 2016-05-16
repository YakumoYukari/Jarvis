using System.Speech.Recognition;

namespace Jarvis.Interfaces
{
    public interface ICommandInterpreter
    {
        Grammar[] GetGrammars();
        void Interpret(string Input);
    }
}
