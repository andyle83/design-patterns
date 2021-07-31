namespace DesignPatterns.CreationalPatterns.Prototype
{
    /// <summary>
    /// Prototype pattern:
    /// Create new object by copying from an existing object.
    /// It will be used when we want to optimize object creation.
    /// </summary>
    public abstract class Prototype
    {
        private string id;

        public Prototype(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public abstract Prototype Clone();
    }
}