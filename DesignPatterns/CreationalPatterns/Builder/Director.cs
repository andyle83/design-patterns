namespace DesignPatterns.CreationalPatterns.Builder
{
    /// <summary>
    /// Constructor process
    /// </summary>
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}