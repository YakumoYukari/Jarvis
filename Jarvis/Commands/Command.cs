using Jarvis.Interfaces;

namespace Jarvis.Commands
{
    public abstract class Command : ICommand
    {
        public string Name { get; protected set; }
        public string SpokenCommand { get; protected set; }

        protected Command(string Name, string SpokenCommand)
        {
            this.Name = Name;
            this.SpokenCommand = SpokenCommand;
        }

        public abstract string Execute(string args);
    }
}
