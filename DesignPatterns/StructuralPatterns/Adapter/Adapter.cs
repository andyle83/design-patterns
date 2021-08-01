namespace DesignPatterns.StructuralPatterns.Adapter
{
    public class Adapter : Target
    {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}