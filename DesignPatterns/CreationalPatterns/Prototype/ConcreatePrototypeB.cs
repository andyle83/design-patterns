namespace DesignPatterns.CreationalPatterns.Prototype
{
    public class ConcreatePrototypeB : Prototype
    {
        public ConcreatePrototypeB(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}