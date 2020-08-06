namespace PatternLibrary.Strategy
{
    internal class ManyTinyQuacks : IQuackStrategy
    {
        public string Quack()
        {
            return "quackquackquack";
        }
    }
}