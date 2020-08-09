using System;
using Xunit;
using PatternLibrary.Strategy;
namespace PatternLibraryTests
{
    public class DuckTests
    {
        [Fact]
        public void Display_GivesString()
        {
            IFlyStrategy f = new Flap();
            IQuackStrategy q = new OneBigQuack();

            Duck d = new Duck(f, q);
            var actual = d.Display();

            Assert.IsType<String>(actual);
        }

        [Fact]
        public void Duck_Composes()
        {
            string expected = "Flap Quack";
            IFlyStrategy f = new TestFlyStrategy();
            IQuackStrategy q = new TestQuackStrategy();

            Duck d = new Duck(f,q);
            string actual = d.Display();

            Assert.Equal(expected,actual);
        }
        [Fact]
        public void Duck_IsModular()
        {
            string expected = "Glide quackquackquack";
            IFlyStrategy f = new Glide();
            IQuackStrategy q = new ManyTinyQuacks();

            Duck d = new Duck(f, q);
            string actual = d.Display();

            Assert.Equal(expected, actual);
        }
    }

    internal class TestQuackStrategy : IQuackStrategy
    {
        public string Quack()
        {
            return "Quack";
        }
    }

    internal class TestFlyStrategy : IFlyStrategy
    {
        public string Fly()
        {
            return "Flap";
        }
    }
}
