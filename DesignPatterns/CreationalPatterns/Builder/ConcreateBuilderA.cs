namespace DesignPatterns.CreationalPatterns.Builder
{
    /// <summary>
    /// Product presentation.
    /// </summary>
    public class ConcreateBuilderA : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("Part A");
        }

        public override void BuildPartB()
        {
            _product.Add("Part B");
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}