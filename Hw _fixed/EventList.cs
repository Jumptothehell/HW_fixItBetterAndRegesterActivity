using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw__fixed
{
    class EventList
    {
        private List<Event> eventLists;

        public EventList()
        {
            this.eventLists = new List<Event>();
        }
        public void AddNewEvent(Event events)
        {
            this.eventLists.Add(events);
        }
        public void RemoveEvent(Event events)
        {
            this.eventLists.Remove(events);
        }
        public int IndexEventPlus1(Event events)
        {
            return this.eventLists.IndexOf(events) + 1;
        }
        public Event returnEventOut(int index)
        {
            Event events = new Event("", "");
            events = this.eventLists[index - 1];
            return events;
        }
        public void FetchcEventList()
        {
            Console.WriteLine("Event List");
            Console.WriteLine("------------");
            foreach (Event events in this.eventLists)
            {
                Console.WriteLine("{0}. Event Name: {1} \nStart Date: {2}\n",eventLists.IndexOf(events) + 1 ,events.name, events.date);
            }
        }
    }
}
