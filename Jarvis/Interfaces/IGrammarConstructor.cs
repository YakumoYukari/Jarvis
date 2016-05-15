using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis.Interfaces
{
    public interface IGrammarConstructor
    {
        void SetRepository(ICommandRepository CommandRepository);
        Grammar ConstructGrammar();
    }
}
