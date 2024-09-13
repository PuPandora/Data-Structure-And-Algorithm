using ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class GameEvent : IPublisher
{
    private List<IObserver> observers = new List<IObserver>();

    public void Add(IObserver observer)
    {
        observers.Add(observer);
    }
    public void Remove(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Reset()
    {
        observers.Clear();
    }

    public void Notify(EventInfo info)
    {
        foreach (IObserver observer in observers)
        {
            observer.Reception(info);
        }
    }
}
