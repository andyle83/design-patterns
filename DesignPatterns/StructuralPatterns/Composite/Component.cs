namespace DesignPatterns.StructuralPatterns.Composite
{
    /// <summary>
    /// Composite Pattern:
    /// Composite objects into a tree structure.
    /// Allow cient treat individual object and composed object uniformly.
    /// </summary>
    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component component);

        public abstract void Remove(Component component);

        public abstract void Display(int depth);
    }
}