namespace DesignPatterns.CreationalPatterns.Singleton
{
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