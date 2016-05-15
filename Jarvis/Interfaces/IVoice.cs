namespace Jarvis.Interfaces
{
    public interface IVoice
    {
        void Speak(string Text);
        void Squelch(); //Shut them up
    }
}
