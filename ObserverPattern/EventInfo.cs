using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class EventInfo
    {
        public string name;
        public string description;
    }

    public class EventInfoBuilder
    {
        public EventInfo eventInfo = new EventInfo();

        public EventInfoBuilder SetName(string name)
        {
            eventInfo.name = name;
            return this;
        }

        public EventInfoBuilder SetDescription(string description)
        {
            eventInfo.description = description;
            return this;
        }

        public EventInfo Build()
        {
            return eventInfo;
        }
    }
}
