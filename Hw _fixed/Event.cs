using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw__fixed
{
    class Event
    {
        public string name;
        public string date;

        public Event(string name, string date)
        {
            this.name = name;
            this.date = date;
        }
        public Event OrientationEvent()
        {
            return new Event("Orientation", "10/09/2021");
        }
        public Event SportEvent()
        {
            return new Event("Sport Day", "10/19/2021");
        }
        public Event GeneralElectionEvent()
        {
            return new Event("General Election", "10/22/2021");
        }
    }
}
