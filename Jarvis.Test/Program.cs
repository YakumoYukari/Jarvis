using Jarvis.Grammars;
using Jarvis.VoiceInput;

namespace Jarvis.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Logging.Logger.Instance.EnableDebug = true;
            
            var OurVoiceCommands = new VoiceCommandRepository();
            CommandRegistration.RegisterCommands(OurVoiceCommands);

            JarvisBot Robot = new JarvisBot(OurVoiceCommands, new BranchingGrammarConstructor());

            Robot.StartListening();

            while (Robot.Running)
            {
                //Doo de doo
            }

        }
    }
}
