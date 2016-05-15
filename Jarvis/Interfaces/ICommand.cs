namespace Jarvis.Interfaces
{
    public interface ICommand
    {
        string Execute(params string[] Args);
    }
}
