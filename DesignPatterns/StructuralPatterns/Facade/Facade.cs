namespace DesignPatterns.StructuralPatterns.Facade
{
    public class Facade
    {
        private SubModuleA moduleA;
        private SubModuleB moduleB;
        private SubModuleC moduleC;

        public Facade()
        {
            moduleA = new SubModuleA();
            moduleB = new SubModuleB();
            moduleC = new SubModuleC();
        }

        public void FirstOperation()
        {
            moduleA.OperationA();
        }

        public void SecondOperation()
        {
            moduleB.OperationB();
            moduleC.OperationC();
        }
    }
}