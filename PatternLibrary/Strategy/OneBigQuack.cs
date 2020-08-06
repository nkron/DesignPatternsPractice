namespace PatternLibrary.Strategy
{
    internal class OneBigQuack : IQuackStrategy
    {
        public string Quack()
        {
            return "QUACK";
        }
    }
}