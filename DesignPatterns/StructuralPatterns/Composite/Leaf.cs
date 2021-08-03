using System;

namespace DesignPatterns.StructuralPatterns.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            throw new Exception("Can  not add to a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void Remove(Component component)
        {
            throw new Exception("Can not remove from a leaf");
        }
    }
}