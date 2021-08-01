namespace DesignPatterns.CreationalPatterns.Singleton
{
    /// <summary>
    /// Singleton pattern:
    /// Ensure a class only have one single instance and provide an access point to that instance.
    /// </summary>

    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Use lazy initialization
            // But not thread safe
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}