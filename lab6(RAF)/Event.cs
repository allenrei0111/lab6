using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_RAF_
{
    //Using C# IDE, create a class called Event that has two properties:
    //event number
    //location

    [Serializable]
    class Event
    {
        public int EventNumber { get; set; }
        public string Location { get; set; }

        public Event(int eventNumber, string location)
        {
            EventNumber = eventNumber;
            Location = location;
        }       
    }
}
