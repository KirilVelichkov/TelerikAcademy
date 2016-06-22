using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{

    public delegate void Callback(Array args);

    public class EventHandler
    {

        Dictionary<string, Dictionary<Callback, Array>> events = new Dictionary<string, Dictionary<Callback, Array>>();

        public EventHandler()
        {

        }

        public void On(string type, Callback md, Array args)
        {
            if (!events.ContainsKey(type))
            {
                events[type] = new Dictionary<Callback, Array>();
            }
            events[type][md] = args;
        }

        public void On(string type, Callback md)
        {
            this.On(type, md, null);
        }

        public void Off(string type)
        {
            if (!events.ContainsKey(type)) return;
            events.Remove(type);
        }

        public void Off(string type, Callback md)
        {
            if (!events.ContainsKey(type)) return;
            if (!events[type].ContainsKey(md)) return;
            events[type].Remove(md);
        }

        public void Trigger(string type)
        {
            foreach (var item in events[type])
            {
                item.Key(events[type][item.Key]);
            }
        }

    }
}
