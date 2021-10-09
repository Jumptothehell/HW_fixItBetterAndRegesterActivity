using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw__fixed
{
    class JoinEventList
    {
        private List<Event> joinEvent;

        public JoinEventList()
        {
            this.joinEvent = new List<Event>();
        }
        public void AddNewJoinEvent(Event events)
        {
            this.joinEvent.Add(events);
        }
        public void RemoveJoinEvent(Event events)
        {
            this.joinEvent.Remove(events);
        }
        public void FetchcJoinEventList()
        {
            foreach (Event events in this.joinEvent)
            {
                Console.WriteLine("{0}. Event Name: {1} \nStart Date: {2}\n", joinEvent.IndexOf(events) + 1, events.name, events.date);
            }
        }
    }
}
