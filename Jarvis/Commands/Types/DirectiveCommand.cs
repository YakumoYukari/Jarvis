namespace Jarvis.Commands.Types
{
    public class DirectiveCommand : Command
    {
        public DirectiveCommand(string Name, string SpokenCommand) : base(Name, SpokenCommand)
        {
        }

        public override string Execute(string Args)
        {
            return "";
        }
    }
}
