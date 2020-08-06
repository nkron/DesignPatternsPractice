namespace PatternLibrary.Strategy
{
    internal class Flap : IFlyStrategy
    {
        public string Fly()
        {
            return "FlapFlapFlap";
        }
    }
}