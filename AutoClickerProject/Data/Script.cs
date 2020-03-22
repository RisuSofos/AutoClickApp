using AutoClickerProject.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClickerProject.ScriptedActions
{
    public class Script
    {
        private static List<MouseAction> _Script = new List<MouseAction>();

        public static void Add(Mouse.MouseEvents Event, Mouse.MousePoint point, uint Repeat, int Delay)
        {
            MouseAction action = new MouseAction()
            {
                PlaceValue = (uint)_Script.Count + 1,
                Event = Event,
                Point = point,
                Repeat = Repeat,
                Delay = Delay
            };
            _Script.Add(action);
        }

        public static List<MouseAction> GetAllActions() => _Script;
        public static MouseAction GetAction(uint PlaceValue) => (from a in _Script where a.PlaceValue == PlaceValue select a).FirstOrDefault();
        public static List<MouseAction> GetAction(uint[] PlaceValue)
        {
            List<MouseAction> selection = new List<MouseAction>();

            foreach (MouseAction x in _Script)
            {
                foreach (uint y in PlaceValue) if (x.PlaceValue == y) selection.Add(x);
            }
            return selection;
        }
    }

    public class MouseAction 
    {
        public uint PlaceValue { get; set; }
        public Mouse.MouseEvents Event { get; set; }
        public Mouse.MousePoint Point { get; set; }
        public uint Repeat { get; set; }
        public int Delay { get; set; }
    }
}
