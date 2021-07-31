namespace DesignPatterns.CreationalPatterns.Builder
{
    /// <summary>
    /// Product presentation.
    /// </summary>
    public class ConcreateBuilderB : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("Part X");
        }

        public override void BuildPartB()
        {
            _product.Add("Part Y");
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}