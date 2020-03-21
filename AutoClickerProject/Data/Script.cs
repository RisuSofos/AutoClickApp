using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClickerProject.Script
{
    public class Script
    {
        private static List<Action> _Script = new List<Action>();

        public static void Add(object Event, uint Repeat, double Delay)
        {
            Action action = new Action()
            {
                PlaceValue = (uint)_Script.Count + 1,
                Event = Event,
                Repeat = Repeat,
                Delay = Delay
            };

            _Script.Add(action);
        }

        public static List<Action> GetAllActions() => _Script;

        public static Action GetAction(uint PlaceValue) => (from a in _Script where a.PlaceValue == PlaceValue select a).FirstOrDefault();
        public static List<Action> GetAction(uint[] PlaceValue)
        {
            List<Action> selection = new List<Action>();

            foreach (Action x in _Script)
            {
                foreach (uint y in PlaceValue) if (x.PlaceValue == y) selection.Add(x);
            }

            return selection;
        }
    }

    public class Action 
    {
        public uint PlaceValue { get; set; }
        public object Event { get; set; }
        public uint Repeat { get; set; }
        public double Delay { get; set; }
    }
}
