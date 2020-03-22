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
                if (action is MouseAction) ;
            }
        }
    }
}
