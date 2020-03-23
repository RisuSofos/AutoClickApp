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
        private static List<Action> _Script = new List<Action>();
        public enum ActionType
        {
            WAIT = 1,
            MOUSE = 2,
            KEYBOARD = 3
        }

        public static void AddAction(object Event, object[] Mods, uint Repeat, int Delay, ActionType Type)
        {
            Action action = new Action()
            {
                PlaceValue = (uint)_Script.Count + 1,
                Repeat = Repeat,
                Delay = Delay,
                Event = Event,
                Mods = Mods,
                type = Type
            };
            _Script.Add(action);
        }
        public static void AddAction(Action newAction) => _Script.Add(newAction);

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
        public uint Repeat { get; set; }
        public int Delay { get; set; }
        public object Event { get; set; }
        public object[] Mods { get; set; }
        public Script.ActionType type { get; set; }
    }
}
