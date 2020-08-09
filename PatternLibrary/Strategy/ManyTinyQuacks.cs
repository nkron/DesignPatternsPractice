namespace PatternLibrary.Strategy
{
    public class ManyTinyQuacks : IQuackStrategy
    {
        public string Quack()
        {
            return "quackquackquack";
        }
    }
}