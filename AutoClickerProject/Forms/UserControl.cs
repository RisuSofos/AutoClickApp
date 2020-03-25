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
            WaitBTN.Checked = true;
        }

        private static void BlankAction()
        {
            ScriptedActions.Action newAction = new ScriptedActions.Action
            {
                Delay = 10000,
                PlaceValue = (uint)(Script.GetAllActions().Count + 1),
                Event = null,
                Mods = null,
                Repeat = 3,
                type = Script.ActionType.WAIT
            };
            Script.AddAction(newAction);
        }

        public async Task RunScript()
        {
            BlankAction();
            foreach (var action in Script.GetAllActions())
            {
                switch (action.type)
                {
                    case Script.ActionType.WAIT:
                        for (uint i = action.Repeat; i > 0; i--)
                        {
                            await Task.Delay(action.Delay);
                        }
                        break;
                    case Script.ActionType.MOUSE:
                        for (uint i = action.Repeat; i >= 0; i--)
                        {

                        }
                        break;
                    case Script.ActionType.KEYBOARD:
                        for (uint i = action.Repeat; i >= 0; i--)
                        {

                        }
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
                action = Script.ActionType.MOUSE;
            }
            else if (KeyboardBTN.Checked)
            {
                action = Script.ActionType.KEYBOARD;
            }
            Script.AddAction(Event, Mods, 1, 1, action);
        }

        private void WaitBTN_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Checked)
            {

                case true:
                    foreach (Control control in Controls) control.Visible = Convert.ToString(control.Tag).Contains("Wait") || control.Tag == null;
                    break;
                case false:
                    foreach (Control control in Controls) control.Visible = !Convert.ToString(control.Tag).Contains("Wait") || control.Tag != null;
                    break;
            }
        }

        private void MouseBTN_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Checked)
            {
                case true:
                    foreach (Control control in this.Controls) control.Visible = Convert.ToString(control.Tag).Contains("Mouse") || control.Tag == null;
                    EventSelect.Items.Clear();
                    EventSelect.Items.Add("CLICK");
                    foreach (string x in Enum.GetNames(typeof(Mouse.MouseEvents))) EventSelect.Items.Add(x);
                    break;
                case false:
                    EventSelect.Items.Clear();
                    xPosTBX.Clear();
                    yPosTBX.Clear();
                    PosBlankCBOX.Checked = false;
                    foreach (Control control in this.Controls) control.Visible = !Convert.ToString(control.Tag).Contains("Mouse") || control.Tag != null;
                    break;
            }
        }
        private readonly int[] _ModValues = new int[] { 0x10, 0x11, 0x12 };
        private void KeyboardBTN_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Checked)
            {
                case true:
                    foreach (Control control in this.Controls) control.Visible = Convert.ToString(control.Tag).Contains("Key") || control.Tag == null;
                    EventSelect.Items.Clear();
                    ModSelect.Items.Clear();
                    foreach (string x in Enum.GetNames(typeof(KeyboardHook.VKeys))) EventSelect.Items.Add(x);
                    foreach (int y in _ModValues) ModSelect.Items.Add(Enum.GetName(typeof(KeyboardHook.VKeys), y));
                    break;
                case false:
                    EventSelect.Items.Clear();
                    ModSelect.Items.Clear();
                    ModItemsTBX.Clear();
                    foreach (Control control in this.Controls) control.Visible = !Convert.ToString(control.Tag).Contains("Key") || control.Tag != null;
                    break;
            }
        }

        private void ModAddBTN_Click(object sender, EventArgs e)
        {
            if ((ModItemsTBX.Text == null || ModItemsTBX.Text == "") && ModSelect.SelectedItem != null) ModItemsTBX.Text = Convert.ToString(ModSelect.SelectedItem);
            else if (ModSelect.SelectedItem != null) ModItemsTBX.Text += $" + {ModSelect.SelectedItem}";
            else MessageBox.Show("No Modification Key to add to Mods", "Field Blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var newItems = ModSelect.Items.Cast<string>().Where(x => x != Convert.ToString(ModSelect.SelectedItem) && !ModItemsTBX.Text.Contains(Convert.ToString(x))); // x is getting the wrong string
            ModSelect.Items.Clear();
            foreach (var x in newItems) ModSelect.Items.Add(Convert.ToString(x));
        }
    }
}