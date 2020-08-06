using System;
using System.Collections.Generic;
using System.Text;

namespace PatternLibrary.Strategy
{
    class Duck
    {
        IFlyStrategy flyStrategy;
        IQuackStrategy quackStrategy;

        //Instead of different kinds of ducks inheriting fly and quack behaviors and overriding them, defining strategies here allows behaviors to be shared, allowing code reuse.
        public Duck(IFlyStrategy flyStrategy, IQuackStrategy quackStrategy)
        {
            this.flyStrategy = flyStrategy;
            this.quackStrategy = quackStrategy;
        }
        public string Display()
        {
            return Fly()+" "+Quack();
        }
        public string Fly()
        {
            return flyStrategy.Fly();
        }
        public string Quack()
        {
            return quackStrategy.Quack();
        }
    }
}
