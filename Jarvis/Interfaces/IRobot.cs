namespace Jarvis.Interfaces
{
    public interface IRobot
    {
        void Speak(string Text);
        void StartListening();
        void StopListening();
        bool IsRunning();
    }
}
