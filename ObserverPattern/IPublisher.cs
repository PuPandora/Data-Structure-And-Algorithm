using ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IPublisher
{
    void Add(IObserver observer);
    void Remove(IObserver observer);
    void Notify(EventInfo info);
}
