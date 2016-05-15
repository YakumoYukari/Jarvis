namespace Jarvis.Interfaces
{
    public interface ICommandMapper
    {
        bool Map(IVoiceCommand VoiceCommand, ICommand Command);
        bool Unmap(IVoiceCommand VoiceCommand);
    }
}
