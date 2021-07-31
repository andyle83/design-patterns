namespace DesignPatterns.CreationalPatterns.Prototype
{
    public class ConcreatePrototypeA : Prototype
    {
        public ConcreatePrototypeA(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}