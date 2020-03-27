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
            // starts off by changing the check to fire the check changed event
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
            try
            {
                ScriptedActions.Action action = new ScriptedActions.Action()
                {
                    Delay = Convert.ToInt32(TimeTBX.Text),
                    Repeat = Convert.ToUInt32(RepeatTBX.Text)
                };
                if (WaitBTN.Checked) action.type = Script.ActionType.WAIT;
                else if (MouseBTN.Checked)
                {
                    action.type = Script.ActionType.MOUSE;
                    if (PosBlankCBOX.Checked == true) action.Mods = null;
                    else if (!string.IsNullOrEmpty(xPosTBX.Text.Trim()) && !string.IsNullOrEmpty(yPosTBX.Text.Trim()))
                    {
                        Point point = new Point
                        (
                            (int)Math.Round(Convert.ToDouble(xPosTBX.Text.Trim())), 
                            (int)Math.Round(Convert.ToDouble(yPosTBX.Text.Trim()))
                        );
                        action.Mods = new object[] { point };
                    }
                }
                else if (KeyboardBTN.Checked)
                {

                }
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("X or Y was not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WaitBTN_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Checked)
            {
                case true:
                    _CurrentSelection = (RadioButton)sender;
                    ShowSelection("Wait", true);
                    break;
                case false:
                    ShowSelection("Wait", false);
                    break;
            }
        }

        public RadioButton _CurrentSelection;
        private void MouseBTN_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Checked)
            {
                case true:

                    _CurrentSelection = (RadioButton)sender;

                    ShowSelection("Mouse", true);

                    break;
                case false:

                    xPosTBX.Clear();
                    yPosTBX.Clear();
                    PosBlankCBOX.Checked = false;

                    ShowSelection("Mouse", false);
                    break;
            }
        }
        private readonly int[] _ModValues = new int[] { 0x10, 0x11, 0x12 };
        private void KeyboardBTN_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Checked)
            {
                case true:

                    _CurrentSelection = (RadioButton)sender;
                    ShowSelection("Key", true);
                    break;
                case false:

                    ShowSelection("Key", true);
                    break;
            }
        }

        private void ModAddBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModItemsTBX.Text) && ModSelect.SelectedItem != null) ModItemsTBX.Text = Convert.ToString(ModSelect.SelectedItem);
            else if (ModSelect.SelectedItem != null) ModItemsTBX.Text += $" + {ModSelect.SelectedItem}";
            else MessageBox.Show("No Modification Key to add to Mods", "Field Blank", MessageBoxButtons.OK, MessageBoxIcon.Error);

            List<string> collectedItems = ModSelect.Items.Cast<string>().ToList();
            List<string> newItems = (from a in collectedItems where a != (string)ModSelect.SelectedItem && !ModItemsTBX.Text.Contains(a) select a).ToList();
            ModSelect.Items.Clear();
            foreach (var x in newItems) ModSelect.Items.Add(Convert.ToString(x));
        }

        //clears all the text in ModItems text box and re-populates the ModSelect Combo box
        private void ClearMod_Click(object sender, EventArgs e)
        {
            ModItemsTBX.Clear();
            foreach (int y in _ModValues) ModSelect.Items.Add(Enum.GetName(typeof(KeyboardHook.VKeys), y));
        }

        /// <summary>
        /// Shows all the contols that contain the specified TAG or dont have a Tag
        /// </summary>
        /// <param name="TAG">The specified Tag</param>
        /// <param name="isShown">True- isVisible, false- isNotVisible</param>
        private void ShowSelection(string TAG, bool isShown)
        {
            switch (isShown)
            {
                case true:
                    foreach (Control control in Controls)
                    {
                        if (Convert.ToString(control.Tag).ToLower().Contains(TAG.ToLower()) || control.Tag == null)
                        {
                            if (control is TextBox) ((TextBox)control).Clear();
                            else if (control is ComboBox)
                            {
                                ((ComboBox)control).Items.Clear();
                                if (TAG.ToLower() == "key")
                                {
                                    foreach (string x in Enum.GetNames(typeof(KeyboardHook.VKeys))) EventSelect.Items.Add(x);
                                    foreach (int y in _ModValues) ModSelect.Items.Add(Enum.GetName(typeof(KeyboardHook.VKeys), y));
                                }
                                else if (TAG.ToLower() == "mouse")
                                {
                                    EventSelect.Items.Add("LEFT_CLICK");
                                    EventSelect.Items.Add("RIGHT_CLICK");
                                    foreach (string x in Enum.GetNames(typeof(Mouse.MouseEvents)))
                                    {
                                        EventSelect.Items.Add(x);
                                    }
                                }
                            }
                            else if (control is CheckBox) ((CheckBox)control).Checked = false;
                            control.Visible = true;
                        }
                    }
                    break;
                case false:
                    foreach (Control control in Controls)
                    {
                        if (!Convert.ToString(control.Tag).Contains(TAG) || control.Tag != null)
                        {
                            if (control is TextBox) ((TextBox)control).Clear();
                            else if (control is ComboBox) ((ComboBox)control).Items.Clear();
                            else if (control is CheckBox) ((CheckBox)control).Checked = false;
                            control.Visible = false;
                        }
                    }
                    break;
            }
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            _CurrentSelection.Checked = false;
            _CurrentSelection.Checked = true;
        }

        private void PosBlankCBOX_CheckedChanged(object sender, EventArgs e)
        {
            switch (((CheckBox)sender).Checked)
            {
                case true:
                    xPosTBX.Clear();
                    xPosTBX.Enabled = false;
                    SelectPosBTN.Enabled = false;
                    break;
                case false:
                    xPosTBX.Enabled = true;
                    SelectPosBTN.Enabled = true;
                    break;
            }
        }
    }
}