using AutoClickerProject.Hooks;
using AutoClickerProject.ScriptedActions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClickerProject
{
    public partial class UserControl : Form
    {
        public UserControl()
        {
            InitializeComponent();
        }

        public async Task RunScript()
        {
            foreach (var action in Script.GetAllActions())
            {
                DelayTimer.Interval = action.Delay;
                switch (action.type) 
                {
                    case Script.ActionType.WAIT:
                        break;
                    case Script.ActionType.MOUSE:
                        break;
                    case Script.ActionType.KEYBOARD:
                        break;
                }
            }
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            object Event = null;
            object[] Mods = new object[] { };
            Script.ActionType action = new Script.ActionType();
            if (WaitBTN.Checked) action = Script.ActionType.WAIT;
            else if (MouseBTN.Checked)
            {

            }
            else if (KeyboardBTN.Checked)
            {

            }
            Script.AddAction(Event, Mods, 1, 1, action);
        }

        private void WaitBTN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MouseBTN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KeyboardBTN_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
