using System;
using System.Collections.Generic;
using System.Text;

namespace PatternLibrary.Observer
{
    public interface IObservable
    {
        void Add(IObserver observer);

        void Remove(IObserver observer);

        string Notify();
    }
}
