namespace Jarvis.Interfaces
{
    public interface ICommandRepository
    {
        bool HasCommand(string UniqueName);
        ICommand GetCommand(string UniqueName);
    }
}
