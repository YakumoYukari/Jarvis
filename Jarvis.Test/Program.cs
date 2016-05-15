namespace Jarvis.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Logging.Logger.Instance.EnableDebug = true;
            
            JarvisBot Robot = new JarvisBot();
            Robot.StartListening();

            while (Robot.Running)
            {
                //Doo de doo
            }

        }
    }
}
