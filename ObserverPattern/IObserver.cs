using ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IObserver
{
    int Id { get; }
    void Reception(EventInfo info);
}
